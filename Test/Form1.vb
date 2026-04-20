Imports System.IO.Ports
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Text
Imports System.Collections.Concurrent
Imports System.IO
Imports ClosedXML.Excel
Imports System.Security.Cryptography
Public Class Form1
    ' --- Data and Communication ---
    Dim WithEvents SerialPort1 As New SerialPort
    Dim WithEvents Timer1 As New Timer
    Dim dataQueue As New ConcurrentQueue(Of String)
    Dim partialLine As String = ""

    Private Const DEBUG_PRINT_PROCESSED_LINE As Boolean = True

    'Constants and Byte Buffer for packet framing
    Private Const Byte_Start As Byte = &H2
    Private Const Byte_End As Byte = &H3
    Private recievedBuffer As New List(Of Byte)

    ' --- Excel Logging for Stopwatch/Laps --- 
    Private lapCounter As Integer = 0
    Dim pathToTop = "..\..\..\"
    Private excelTemplatePath_lap As String = Path.Combine(Path.Combine(Application.StartupPath, pathToTop), "lap_template.xlsx")
    Private excelTemplatePath_data As String = Path.Combine(Application.StartupPath, "data_template.xlsx")
    Private excelFolderPath As String = ""
    Private excelFilePath_lap As String = ""
    Private excelFilePath_data As String = ""
    Private openWorkbook_lap As XLWorkbook = Nothing
    Private openWorkbook_data As XLWorkbook = Nothing
    Private lapTitles As String() = {
        "Lap Number",
        "Lap Time Total",
        "Global Start Time",
        "Global End Time",
        "Real-Time"
    }
    Private dataTitles As String() = {
        "Time",
        "RPM_C",
        "RPM_L",
        "RPM_R",
        "RPM_CRANK",
        "RPM_SHAFT",
        "Total Speed",
        "Steering Angle",
        "Gear",
        "Voltage Gear Battery",
        "rl",
        "ph",
        "yw",
        "Temp",
        "HUM",
        "Press",
        "Voltage Pi",
        "Voltage Analogue",
        "GPS_lat",
        "GPS_long",
        "GPS_Speed",
        "GPS_alt",
        "GPS_sat",
        "Distance",
        "Power",
        "Cadence"
    }

    Dim chartTickCounter As Integer = 0

    '-----StopWatch--------------'
    Private sw As New Stopwatch()
    Private lapTimes As New List(Of TimeSpan)()
    Private previousLapTime As TimeSpan = TimeSpan.Zero

    ' --- Metrics ---
    Dim Data As List(Of Decimal)
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

    Dim originalGearRatios As New Dictionary(Of Decimal, Decimal) From {{1D, 2.81D}, {2D, 3.21D}, {3D, 3.6D}, {4D, 4.09D}, {5D, 4.5D}, {6D, 5.29D}}
    Dim expectedGearRatios As New Dictionary(Of Decimal, Decimal) From {{1D, 2.81D}, {2D, 3.21D}, {3D, 3.6D}, {4D, 4.09D}, {5D, 4.5D}, {6D, 5.29D}}
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

        TextBox_Gear1_Display.Text = expectedGearRatios(1).ToString()
        TextBox_Gear2_Display.Text = expectedGearRatios(2).ToString()
        TextBox_Gear3_Display.Text = expectedGearRatios(3).ToString()
        TextBox_Gear4_Display.Text = expectedGearRatios(4).ToString()
        TextBox_Gear5_Display.Text = expectedGearRatios(5).ToString()
        TextBox_Gear6_Display.Text = expectedGearRatios(6).ToString()

        'MessageBox.Show(Application.StartupPath)

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Timer1.Stop()
        Timer2.Stop()
        If SerialPort1.IsOpen Then SerialPort1.Close()
        Try
            SaveAndDisposeWorkbook(openWorkbook_lap)
            SaveAndDisposeWorkbook(openWorkbook_data)
        Catch ex As Exception
        End Try
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

    Private Sub CreateWorkbookFromTemplateOrDefault(filePath As String, templatePath As String, titles() As String, tableName As String)
        If File.Exists(templatePath) Then
            File.Copy(templatePath, filePath, overwrite:=True)
        Else
            Using wb As New XLWorkbook()
                Dim ws = wb.Worksheets.Add("Sheet1")
                For i = 0 To titles.Length - 1
                    ws.Cell(1, i + 1).Value = titles(i)
                Next
                ws.Range(ws.Cell(1, 1), ws.Cell(1, titles.Length)).CreateTable(tableName)
                wb.SaveAs(filePath)
            End Using
        End If
    End Sub

    Private Sub OpenWorkbookIfNeeded(ByRef workbook As XLWorkbook, excelFilePath As String)
        If workbook Is Nothing AndAlso Not String.IsNullOrEmpty(excelFilePath) AndAlso File.Exists(excelFilePath) Then
            workbook = New XLWorkbook(excelFilePath)
        End If
    End Sub

    Private Sub SaveAndDisposeWorkbook(ByRef workbook As XLWorkbook)
        If workbook IsNot Nothing Then
            Try
                workbook.Save()
            Catch ex As Exception
            Finally
                workbook.Dispose()
                workbook = Nothing
            End Try
        End If
    End Sub

    Private Function EnsureTable(ws As IXLWorksheet, titles() As String, tableName As String) As IXLTable
        Dim tbl As IXLTable = Nothing
        If ws.Tables.Any(Function(t) t.Name = tableName) Then
            tbl = ws.Table(tableName)
        ElseIf ws.Tables.Any() Then
            tbl = ws.Tables.First()
        Else
            If ws.Cell(1, 1).IsEmpty Then
                For index = 0 To titles.Length - 1
                    ws.Cell(1, index + 1).Value = titles(index)
                Next
            End If
            tbl = ws.Range(ws.Cell(1, 1), ws.Cell(1, titles.Length)).CreateTable(tableName)
        End If
        Return tbl
    End Function

    Private Sub AppendLap(lapNumber As Integer, lapInterval As TimeSpan, startTime As TimeSpan, endTime As TimeSpan)
        Try
            OpenWorkbookIfNeeded(openWorkbook_lap, excelFilePath_lap)
            If openWorkbook_lap Is Nothing Then Return

            Dim ws = openWorkbook_lap.Worksheet(1)
            Dim tbl = EnsureTable(ws, lapTitles, "LapTimes")

            tbl.InsertRowsBelow(1)
            Dim lastRangeRow = tbl.DataRange.LastRow()
            Dim rowNumber = lastRangeRow.RangeAddress.FirstAddress.RowNumber
            Dim newRow As IXLRow = ws.Row(rowNumber)

            newRow.Cell(1).Value = lapNumber
            newRow.Cell(2).Value = lapInterval.ToString("hh\:mm\:ss\.fff")
            newRow.Cell(3).Value = startTime.ToString("hh\:mm\:ss\.fff")
            newRow.Cell(4).Value = endTime.ToString("hh\:mm\:ss\.fff")
            newRow.Cell(5).Value = DateTime.Now.ToString("HH:mm:ss.fff")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AppendData()
        Try
            If Data Is Nothing OrElse Data.Count = 0 Then Return
            OpenWorkbookIfNeeded(openWorkbook_data, excelFilePath_data)
            If openWorkbook_data Is Nothing Then Return

            Dim ws = openWorkbook_data.Worksheet(1)
            Dim tbl = EnsureTable(ws, dataTitles, "DataLog")
            tbl.InsertRowsBelow(1)
            Dim lastRangeRow = tbl.DataRange.LastRow()
            Dim rowNumber = lastRangeRow.RangeAddress.FirstAddress.RowNumber
            Dim newRow As IXLRow = ws.Row(rowNumber)
            newRow.Cell(1).Value = DateTime.Now.ToString("HH:mm:ss.fff")
            For index = 0 To Math.Min(Data.Count - 1, dataTitles.Length - 1) ' Ensure we don't exceed column count
                newRow.Cell(index + 2).Value = Data(index)
            Next
        Catch ex As Exception
            Debug.Write("AppendData error: " & ex.Message)
        End Try
    End Sub

    Private Sub SaveCloseLap()
        If openWorkbook_lap IsNot Nothing Then
            Try
                openWorkbook_lap.Save()
            Catch ex As Exception
            Finally
                openWorkbook_lap.Dispose()
                openWorkbook_lap = Nothing
            End Try
        End If
    End Sub

    Private Sub SaveCloseData()
        If openWorkbook_data IsNot Nothing Then
            Try
                openWorkbook_data.Save()
            Catch ex As Exception
            Finally
                openWorkbook_data.Dispose()
                openWorkbook_data = Nothing
            End Try
        End If
    End Sub

    ' --- Serial Handling ---
    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            Dim bytes_to_read As Integer = SerialPort1.BytesToRead
            If bytes_to_read <= 0 Then Return

            Dim buffer(bytes_to_read - 1) As Byte
            SerialPort1.Read(buffer, 0, bytes_to_read)

            SyncLock recievedBuffer
                recievedBuffer.AddRange(buffer)

                While True
                    Dim startIndex As Integer = recievedBuffer.IndexOf(Byte_Start)
                    If startIndex = -1 Then
                        Const MaxBufferSize As Integer = 8192
                        If recievedBuffer.Count > MaxBufferSize Then
                            recievedBuffer.RemoveRange(0, recievedBuffer.Count - MaxBufferSize)
                            Console.WriteLine("Warning: recievedBuffer trimmed to avoid growth.")
                        End If
                        Exit While
                    End If

                    Dim endIndex As Integer = recievedBuffer.IndexOf(Byte_End, startIndex + 1)
                    If endIndex = -1 Then
                        If startIndex > 0 Then
                            recievedBuffer.RemoveRange(0, startIndex)
                        End If
                        Exit While
                    End If

                    Dim payloadLength As Integer = endIndex - (startIndex + 1)
                    If payloadLength > 0 Then
                        Dim payload(payloadLength - 1) As Byte
                        recievedBuffer.CopyTo(startIndex + 1, payload, 0, payloadLength)
                        Dim line As String = Encoding.UTF8.GetString(payload).Trim(ControlChars.Cr, ControlChars.Lf, " "c, vbTab)
                        If Not String.IsNullOrEmpty(line) Then
                            dataQueue.Enqueue(line)
                        End If
                    Else
                    End If

                    recievedBuffer.RemoveRange(0, endIndex + 1)
                End While
            End SyncLock
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

    Private Sub Button_GearSubmit_Click(sender As Object, e As EventArgs) Handles Button_GearSubmit.Click
        For i As Integer = 1 To expectedGearRatios.Count
            Dim TextBoxName = $"TextBox_Gear{i}"
            Dim TextBoxDisplayName = $"TextBox_Gear{i}_Display"
            Dim ctrls = Me.Controls.Find(TextBoxName, True)
            Dim display = Me.Controls.Find(TextBoxDisplayName, True)
            If ctrls.Length = 0 OrElse TypeOf ctrls(0) IsNot TextBox Then
                Continue For
            End If
            Dim tbd = CType(display(0), TextBox)
            Dim tb = CType(ctrls(0), TextBox)
            Dim txt = tb.Text.Trim()
            Dim gear As Decimal
            If Decimal.TryParse(txt, System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, gear) Then
                expectedGearRatios(i) = gear
                tbd.Text = txt
                tb.Text = Nothing
            ElseIf String.IsNullOrEmpty(txt) Then
                Continue For
            Else
                MessageBox.Show($"Invalid input for Gear {i}. Please enter a valid decimal number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tb.Text = Nothing
            End If
        Next
    End Sub

    Private Sub Button_GearReset_Click(sender As Object, e As EventArgs) Handles Button_GearReset.Click
        For i As Integer = 1 To expectedGearRatios.Count
            Dim TextBoxDisplayName = $"TextBox_Gear{i}_Display"
            Dim display = Me.Controls.Find(TextBoxDisplayName, True)
            Dim tbd = CType(display(0), TextBox)
            expectedGearRatios(i) = originalGearRatios(i)
            tbd.Text = expectedGearRatios(i).ToString()
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
        If s.Length < dataTitles.Length Then Return
        If Not Decimal.TryParse(s(0), RPM_C) OrElse Not Decimal.TryParse(s(1), RPM_L) OrElse Not Decimal.TryParse(s(2), RPM_R) Then Return
        Dim vals As New List(Of Decimal)
        Dim parsedValue As Decimal
        For Each str As String In s
            If Decimal.TryParse(str, parsedValue) Then
                vals.Add(parsedValue)
            Else
                Debug.WriteLine($"Could Not Parse: '{str}'")
            End If
        Next
        Data = vals
        RPM_CR = vals(3)
        RPM_C = vals(0)
        RPM_S = vals(4)
        Total_Speed = vals(5)
        Distance = vals(22)
        POWER = vals(23)
        Gear = vals(7)
        BatG = vals(8)
        BatPi = vals(15)
        BatAna = vals(16)
        rl = vals(9)
        ph = vals(10)
        yw = vals(11)

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
        Dim gearKey As Decimal
        Dim toleranceG = 0.3D
        If Decimal.TryParse(s(7).Trim(), gearKey) Then
            If expectedGearRatios.ContainsKey(gearKey) Then
                Dim expected = expectedGearRatios(gearKey)
                If actualGearRatio < (expected - toleranceG) Or actualGearRatio > (expected + toleranceG) Then
                    Comparsion(actualGearRatio)
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

        'Update Log
        AppendData()
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
    'To calculate the gear ratio its just chainring gear/ Rear gear {1D, 2.81D}, {2D, 3.21D}, {3D, 3.6D}, {4D, 4.09D}, {5D, 4.5D}, {6D, 5.29D}
    Private Sub Comparsion(actualratio As Decimal)
        If actualratio <= expectedGearRatios(1) Then
            actualgear = 1
        ElseIf actualratio >= expectedGearRatios(1) And actualratio <= expectedGearRatios(2) Then
            actualgear = 2
        ElseIf actualratio >= expectedGearRatios(2) And actualratio <= expectedGearRatios(3) Then
            actualgear = 3
        ElseIf actualratio >= expectedGearRatios(3) And actualratio <= expectedGearRatios(4) Then
            actualgear = 4
        ElseIf actualratio >= expectedGearRatios(4) And actualratio <= expectedGearRatios(5) Then
            actualgear = 5
        ElseIf actualratio >= expectedGearRatios(5) And actualratio <= expectedGearRatios(6) Then
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
        MsgBox("Disconnected successfully!")
    End Sub

    Private Sub btnStartStop_click(sender As Object, e As EventArgs) Handles btnStartStop.Click
        If sw.IsRunning Then
            SaveAndDisposeWorkbook(openWorkbook_lap)
            SaveAndDisposeWorkbook(openWorkbook_data)
            sw.Stop()
            Timer2.Enabled = False
            btnStartStop.Text = "Start"
            btnReset.Text = "Reset"
        Else
            lapCounter = 0
            previousLapTime = TimeSpan.Zero

            Dim time = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")
            Dim fileName_lap = "lap_" + time & ".xlsx"
            Dim fileName_data = "data_" + time & ".xlsx"
            Dim path_from_debug = pathToTop + "Log_Files\" + time
            Dim logFolder = Path.Combine(Application.StartupPath, path_from_debug)

            If Not Directory.Exists(logFolder) Then Directory.CreateDirectory(logFolder)
            excelFilePath_lap = Path.Combine(logFolder, fileName_lap)
            excelFilePath_data = Path.Combine(logFolder, fileName_data)

            MessageBox.Show(excelFilePath_lap)

            CreateWorkbookFromTemplateOrDefault(excelFilePath_lap, excelTemplatePath_lap, lapTitles, "LapTimes")
            CreateWorkbookFromTemplateOrDefault(excelFilePath_data, excelTemplatePath_data, dataTitles, "DataLog")
            openWorkbook_lap = New XLWorkbook(excelFilePath_lap)
            openWorkbook_data = New XLWorkbook(excelFilePath_data)

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
            AppendLap(lapCounter, lapInterval, previousLapTime, currentLapTime)

            ' Format the lap time string
            Dim lapText As String = $"Lap {lapCounter}: {lapInterval.ToString("hh\:mm\:ss\.fff")}"

            ' Add to ListBox and list
            lapTimes.Add(currentLapTime)
            lbLaps.Items.Insert(0, lapText)
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
        If e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True ' Prevent beep sound
            btnLapReset_Click(sender, e)
        End If
    End Sub

End Class
