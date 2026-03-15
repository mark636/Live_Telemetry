Imports System.IO.Ports
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Text
Imports System.Collections.Concurrent
Imports System.Diagnostics
Imports System.IO
Imports ClosedXML.Excel
Public Class Form1
    ' --- Data and Communication ---
    Dim WithEvents SerialPort1 As New SerialPort
    Dim WithEvents Timer1 As New Timer
    Dim dataQueue As New ConcurrentQueue(Of String)
    Dim partialLine As String = ""

    ' --- Excel Logging for Stopwatch/Laps --- 
    Private lapCounter As Integer = 0
    Private excelTemplatePath As String = Path.Combine(Application.StartupPath, "template.xlsx")
    Private excelFilePath As String = ""
    Private openWorkbook As XLWorkbook = Nothing

    '-----StopWatch--------------'
    Private sw As New Stopwatch()
    Private lapTimes As New List(Of TimeSpan)()
    Private previousLapTime As TimeSpan = TimeSpan.Zero

    ' --- Metrics ---
    Dim RPM_C, RPM_L, RPM_R, RPM_CR, RPM_S, Total_Speed, POWER, Steering_A, TEMP, HUMD, PRESS, Distance, actualGearRatio, actualChainRatio As Decimal
    Dim maxspeed As Decimal = -2
    Dim actualgear As Integer
    Dim Gear As Integer
    Dim Limit As Integer = 20
    Dim DTF As Decimal
    Dim settingsForm As New Form2
    Dim BatG As Decimal
    Dim BatPi As Decimal
    Dim BatAna As Decimal
    Dim rl As Decimal
    Dim ph As Decimal
    Dim yw As Decimal

    ' --- Initialization ---
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialPort1.Close()
        SerialPort1.BaudRate = 115200
        SerialPort1.DataBits = 8
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.Handshake = Handshake.None
        SerialPort1.Encoding = Encoding.UTF8

        Timer1.Interval = 40
        Timer1.Start()

        InitializeChart(Chart1, "SPEED", {"TOTAL SPEED"})
        InitializeChart(Chart2, "POWER", {"POWER", "TARGET POWER"})

        Chart1.ChartAreas(0).AxisY.Maximum = 120
        Chart2.ChartAreas(0).AxisY.Maximum = 450

        lbLaps.DrawMode = DrawMode.OwnerDrawFixed

        ' Enable KeyPreview so the form receives key events before controls
        Me.KeyPreview = True


    End Sub

    Private Sub InitializeChart(chart As Chart, title As String, seriesNames() As String)
        chart.Series.Clear()
        chart.Titles.Clear()
        chart.ChartAreas.Clear()
        chart.Titles.Add(title)
        chart.ChartAreas.Add(New ChartArea())
        For Each seriesName In seriesNames
            Dim series As New Series(seriesName) With {.ChartType = SeriesChartType.Line}
            chart.Series.Add(series)
        Next
    End Sub

    ' --- Serial Handling ---
    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            Dim data As String = SerialPort1.ReadExisting()
            Dim lines = (partialLine & data).Split(ControlChars.Lf)
            For i = 0 To lines.Length - 2
                dataQueue.Enqueue(lines(i).Trim())
            Next
            partialLine = lines.Last()
        Catch ex As Exception
            Console.WriteLine("Serial error: " & ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim linesToProcess As Integer = 5 ' Tune this if needed
        Dim line As String = Nothing

        For i As Integer = 1 To linesToProcess
            If dataQueue.TryDequeue(line) Then
                ProcessLine(line)
            Else
                Exit For
            End If
        Next
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ' Update the main display label with the formatted time
        lblTime.Text = sw.Elapsed.ToString("mm\:ss\.fff")
    End Sub

    ' --- Data Processing ---
    Private Sub ProcessLine(line As String)
        If String.IsNullOrEmpty(line) OrElse Not line.Contains(",") Then Return
        Dim s() As String = line.Split(",")
        If s.Length < 25 Then Return

        If Not Decimal.TryParse(s(0), RPM_C) OrElse Not Decimal.TryParse(s(1), RPM_L) OrElse Not Decimal.TryParse(s(2), RPM_R) Then Return
        Decimal.TryParse(s(3), RPM_CR)
        Decimal.TryParse(s(0), RPM_C)
        Decimal.TryParse(s(4), RPM_S)
        Decimal.TryParse(s(5), Total_Speed)
        Decimal.TryParse(s(22), Distance)
        Decimal.TryParse(s(23), POWER)
        Decimal.TryParse(s(7), Gear)
        Decimal.TryParse(s(8), BatG)
        Decimal.TryParse(s(15), BatPi)
        Decimal.TryParse(s(16), BatAna)
        Decimal.TryParse(s(9), rl)
        Decimal.TryParse(s(10), ph)
        Decimal.TryParse(s(11), yw)

        LbPower.Invoke(Sub() LbPower.Text = POWER.ToString())
        LbGear2.Invoke(Sub() LbGear2.Text = Gear.ToString())
        LbBatG.Invoke(Sub() LbBatG.Text = BatG.ToString())
        LbCranks.Invoke(Sub() LbCranks.Text = RPM_CR.ToString())
        LbBatteryPi.Invoke(Sub() LbBatteryPi.Text = BatPi.ToString())
        LbAnalog.Invoke(Sub() LbAnalog.Text = BatAna.ToString())
        LbSenRl.Invoke(Sub() LbSenRl.Text = rl.ToString())
        LbSenPH.Invoke(Sub() LbSenPH.Text = ph.ToString())
        LbSenYW.Invoke(Sub() LbSenYW.Text = yw.ToString())

        UpdateGearChainRatio(RPM_CR, RPM_S, RPM_C)
        UpdateCharts(Total_Speed, POWER)

        ' --- Gear Check ---
        Dim expectedGearRatios As New Dictionary(Of Decimal, Decimal) From {
        {1D, 2.81D}, {2D, 3.21D}, {3D, 3.6D},
        {4D, 4.09D}, {5D, 4.5D}, {6D, 5.29D}
        }

        Dim gearKey As Decimal
        Dim toleranceG = 0.3D
        If Decimal.TryParse(s(7).Trim(), gearKey) Then
            If expectedGearRatios.ContainsKey(gearKey) Then
                Dim expected = expectedGearRatios(gearKey)
                If actualGearRatio < (expected - toleranceG) Or actualGearRatio > (expected + toleranceG) Then
                    comparsion(actualGearRatio)
                    Label8.Invoke(Sub()
                                      Label8.Text = $"GEAR RATIO: {actualGearRatio:F2} Gear: {actualgear}"
                                      GroupBox4.BackColor = Color.Red
                                  End Sub)
                Else
                    Label8.Invoke(Sub()
                                      Label8.Text = "STATUS: OK!"
                                      GroupBox4.BackColor = Color.FromArgb(128, 255, 128)
                                  End Sub)
                End If
            End If
        Else
            Label8.Invoke(Sub()
                              Label8.Text = "Invalid Gear Data"
                              GroupBox4.BackColor = Color.Gray
                          End Sub)
        End If

        ' --- Wheel RPM Comparison ---
        Dim diff1to2 As Decimal = Math.Abs(RPM_C - RPM_L)
        Dim diff2to3 As Decimal = Math.Abs(RPM_L - RPM_R)
        Dim diff1to3 As Decimal = Math.Abs(RPM_C - RPM_R)
        Dim toleranceW = 15D

        If diff1to2 <= toleranceW AndAlso diff2to3 <= toleranceW AndAlso diff1to3 <= toleranceW Then
            GroupBox1.Invoke(Sub() GroupBox1.BackColor = Color.FromArgb(128, 255, 128))
            GroupBox2.Invoke(Sub() GroupBox2.BackColor = Color.FromArgb(128, 255, 128))
            GroupBox3.Invoke(Sub() GroupBox3.BackColor = Color.FromArgb(128, 255, 128))
            Label4.Text = "STATUS: OK!"
            Label6.Text = "STATUS: OK!"
            Label7.Text = "STATUS: OK!"
        Else
            If diff1to2 > toleranceW And diff1to3 > toleranceW Then
                GroupBox1.Invoke(Sub()
                                     GroupBox1.BackColor = Color.Red
                                     Label4.Text = $"diff1to2: {diff1to2:F2}, diff1to3: {diff1to3:F2}"
                                 End Sub)
            End If
            If diff1to2 > toleranceW And diff2to3 > toleranceW Then
                GroupBox2.Invoke(Sub()
                                     GroupBox2.BackColor = Color.Red
                                     Label6.Text = $"diff1to2: {diff1to2:F2}, diff2to3: {diff2to3:F2}"
                                 End Sub)
            End If
            If diff1to3 > toleranceW And diff2to3 > toleranceW Then
                GroupBox3.Invoke(Sub()
                                     GroupBox3.BackColor = Color.Red
                                     Label7.Text = $"diff1to3: {diff1to3:F2}, diff2to3: {diff2to3:F2}"
                                 End Sub)
            End If
        End If

        '------ Rear chain ratio ----'
        Dim expectedrgratio = 1.4375 'Intermediate drive teeth/freewheel 
        If actualChainRatio < (expectedrgratio - toleranceG) Or actualChainRatio > (expectedrgratio + toleranceG) Then
            LbChain.Invoke(Sub()
                               LbChain.Text = $"Rear RATIO: {actualChainRatio:F2}"
                               GroupBox5.BackColor = Color.Red
                           End Sub)
        Else
            LbChain.Invoke(Sub()
                               LbChain.Text = "STATUS: OK!"
                               GroupBox5.BackColor = Color.FromArgb(128, 255, 128)
                           End Sub)
        End If

        ' Max speed and UI
        If Total_Speed > maxspeed Then maxspeed = Total_Speed
        Lbmax.Invoke(Sub() Lbmax.Text = $"{maxspeed} KPH")
        LbSpeed2.Invoke(Sub() LbSpeed2.Text = $"{Total_Speed} KPH")
    End Sub

    Private Sub UpdateGearChainRatio(RPM_CR As Decimal, RPM_S As Decimal, RPM_C As Decimal)
        ' Calculate gear ratio (Chainring RPM / Sprocket RPM)
        If RPM_CR > 0 Then
            actualGearRatio = RPM_S / RPM_CR
        Else
            actualGearRatio = 0S
        End If

        ' Calculate chain ratio (Wheel RPM / Shaft RPM)
        If RPM_S > 0 Then
            actualChainRatio = RPM_C / RPM_S
        Else
            actualChainRatio = 0
        End If
    End Sub

    Dim chartTickCounter As Integer = 0
    Private Sub UpdateCharts(speed As Decimal, power As Decimal)
        chartTickCounter += 1
        If chartTickCounter Mod 10 <> 0 Then Return ' Update charts less frequently

        Chart1.Invoke(Sub()
                          Dim s = Chart1.Series("TOTAL SPEED")
                          s.Points.AddY(speed)
                          If s.Points.Count > Limit Then s.Points.RemoveAt(0)
                      End Sub)
        Chart2.Invoke(Sub()
                          Dim s = Chart2.Series("POWER")
                          s.Points.AddY(power)
                          If s.Points.Count > Limit Then s.Points.RemoveAt(0)
                      End Sub)
    End Sub
    'To calculate the gear ratio its just chainring gear/ Rear gear 
    Private Sub comparsion(actualratio As Decimal)
        If actualratio <= 2.81 Then
            actualgear = 1
        ElseIf actualratio >= 2.81 And actualratio <= 3.21 Then
            actualgear = 2
        ElseIf actualratio >= 3.21 And actualratio <= 3.6 Then
            actualgear = 3
        ElseIf actualratio >= 3.6 And actualratio <= 4.09 Then
            actualgear = 4
        ElseIf actualratio >= 4.09 And actualratio <= 4.5 Then
            actualgear = 5
        ElseIf actualratio >= 4.5 And actualratio <= 5.29 Then
            actualgear = 6
        Else
            actualgear = 0
        End If
    End Sub

    ' --- Port Setup & Settings ---
    Private Sub ButtonScanPort_Click(sender As Object, e As EventArgs) Handles ButtonScanPort.Click
        ComboBoxPort.Items.Clear()
        Dim ports = SerialPort.GetPortNames()
        ComboBoxPort.Items.AddRange(ports)
        If ports.Any() Then
            ComboBoxPort.SelectedIndex = 0
            ButtonConnect.Enabled = True
        Else
            MsgBox("No COM ports detected")
            ButtonConnect.Enabled = False
        End If
    End Sub

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        Try
            If ComboBoxPort.SelectedItem Is Nothing Then
                MsgBox("Select a COM port first.")
                Return
            End If
            If SerialPort1.IsOpen Then
                MsgBox("Port already open.")
                Return
            End If
            SerialPort1.PortName = ComboBoxPort.SelectedItem.ToString()
            SerialPort1.Open()
            Timer1.Start()
            MsgBox("Connected successfully!")
        Catch ex As Exception
            MsgBox("Connection error: " & ex.Message)
        End Try
    End Sub
    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        SerialPort1.Close()
        Timer1.Stop()
    End Sub

    Private Sub btnStartStop_click(sender As Object, e As EventArgs) Handles btnStartStop.Click
        If sw.IsRunning Then
            If openWorkbook IsNot Nothing Then
                Try
                    openWorkbook.Save()
                Catch ex As Exception
                Finally
                    openWorkbook.Dispose()
                    openWorkbook = Nothing
                End Try
            End If

            sw.Stop()
            Timer2.Enabled = False
            btnStartStop.Text = "Start"
            btnReset.Text = "Reset"
        Else
            lapCounter = 0
            previousLapTime = TimeSpan.Zero

            Dim fileName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") & ".xlsx"
            Dim logFolder = Path.Combine(Application.StartupPath, "Log_Files")
            If Not Directory.Exists(logFolder) Then Directory.CreateDirectory(logFolder)
            excelFilePath = Path.Combine(logFolder, fileName)

            If File.Exists(excelTemplatePath) Then
                File.Copy(excelTemplatePath, excelFilePath, overwrite:=True)
            Else
                Using wb As New XLWorkbook()
                    Dim ws = wb.Worksheets.Add("Sheet1")
                    ws.Cell(1, 1).Value = "Lap Number"
                    ws.Cell(1, 2).Value = "Lap Time Total"
                    ws.Cell(1, 3).Value = "Global Start Time"
                    ws.Cell(1, 4).Value = "Global End Time"
                    ws.Cell(1, 5).Value = "Real-Time"
                    ws.Range("A1:E1").CreateTable("LapTimes")
                    wb.SaveAs(excelFilePath)
                End Using
            End If

            If openWorkbook IsNot Nothing Then
                Try
                    openWorkbook.Dispose()
                Catch ex As Exception
                Finally
                    openWorkbook = Nothing
                End Try
            End If

            openWorkbook = New XLWorkbook(excelFilePath)

            sw.Start()
            Timer2.Enabled = True
            btnStartStop.Text = "Stop"
            btnReset.Text = "Lap"
        End If
    End Sub
    Private Sub btnLapReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If sw.IsRunning Then
            ' Lap functionality
            Dim currentLapTime As TimeSpan = sw.Elapsed
            Dim lapInterval As TimeSpan = currentLapTime.Subtract(previousLapTime)

            lapCounter += 1

            Try
                If openWorkbook Is Nothing Then
                    ' Fallback: open the file if not already open
                    openWorkbook = New XLWorkbook(excelFilePath)
                End If

                Dim ws = openWorkbook.Worksheet(1)

                ' Find or create the table
                Dim tbl As IXLTable = Nothing
                If ws.Tables.Any(Function(t) t.Name = "LapTimes") Then
                    tbl = ws.Table("LapTimes")
                ElseIf ws.Tables.Any() Then
                    tbl = ws.Tables.First()
                Else
                    If ws.Cell(1, 1).IsEmpty() Then
                        ws.Cell(1, 1).Value = "Lap Number"
                        ws.Cell(1, 2).Value = "Lap Time Total"
                        ws.Cell(1, 3).Value = "Global Start Time"
                        ws.Cell(1, 4).Value = "Global End Time"
                        ws.Cell(1, 5).Value = "Real-Time"
                    End If
                    tbl = ws.Range("A1:E1").CreateTable("LapTimes")
                End If

                ' Insert a row in the table and write values (in-memory)
                tbl.InsertRowsBelow(1)
                Dim lastRangeRow = tbl.DataRange.LastRow()
                Dim rowNumber = lastRangeRow.RangeAddress.FirstAddress.RowNumber
                Dim newRow As IXLRow = ws.Row(rowNumber)

                newRow.Cell(1).Value = lapCounter
                newRow.Cell(2).Value = lapInterval.ToString("hh\:mm\:ss\.fff")
                newRow.Cell(3).Value = previousLapTime.ToString("hh\:mm\:ss\.fff")
                newRow.Cell(4).Value = currentLapTime.ToString("hh\:mm\:ss\.fff")
                newRow.Cell(5).Value = DateTime.Now.ToString("HH:mm:ss.fff")

                ' Do NOT call Save() here to avoid blocking — workbook is saved on Stop
            Catch ex As Exception
                MessageBox.Show("Failed to write lap to Excel: " & ex.Message, "Excel Write Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            ' Format the lap time string
            Dim lapText As String = $"Lap {lapCounter}: {lapInterval.ToString("hh\:mm\:ss\.fff")}"

            ' Add to ListBox and list
            lbLaps.Items.Insert(0, lapText)
            lapTimes.Add(currentLapTime)
            previousLapTime = currentLapTime
        Else
            ' Reset functionality
            sw.Reset()
            previousLapTime = TimeSpan.Zero
            lapTimes.Clear()
            lbLaps.Items.Clear()
            lblTime.Text = "00:00.000"
            btnReset.Text = "Lap"


        End If
    End Sub


    ' Add this to enable custom drawing for the ListBox
    Private Sub lbLaps_DrawItem(sender As Object, e As DrawItemEventArgs) Handles lbLaps.DrawItem
        If e.Index < 0 Then Return

        e.DrawBackground()

        Dim itemText As String = lbLaps.Items(e.Index).ToString()
        Dim brush As Brush = Brushes.Black

        ' Determine color based on comparison with previous lap
        ' Index 0 is the most recent lap
        If e.Index < lbLaps.Items.Count - 1 Then ' Not the first lap
            Dim currentLapNum As Integer = lapTimes.Count - e.Index
            Dim previousLapNum As Integer = currentLapNum - 1

            If previousLapNum > 0 Then
                Dim currentInterval As TimeSpan = lapTimes(currentLapNum - 1).Subtract(If(currentLapNum > 1, lapTimes(currentLapNum - 2), TimeSpan.Zero))
                Dim previousInterval As TimeSpan = lapTimes(previousLapNum - 1).Subtract(If(previousLapNum > 1, lapTimes(previousLapNum - 2), TimeSpan.Zero))

                If currentInterval < previousInterval Then
                    brush = Brushes.Green ' Faster lap
                ElseIf currentInterval > previousInterval Then
                    brush = Brushes.Red ' Slower lap
                End If
            End If
        End If

        e.Graphics.DrawString(itemText, e.Font, brush, e.Bounds)
        e.DrawFocusRectangle()
    End Sub

    ' Add this event to handle Enter key press
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent beep sound
            btnLapReset_Click(sender, e)
        End If
    End Sub





End Class
