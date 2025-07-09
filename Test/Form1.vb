' Refactored VB.NET Telemetry Dashboard
Imports System.IO.Ports
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Text
Imports System.Collections.Concurrent

Public Class Form1
    ' --- Data and Communication ---
    Dim WithEvents SerialPort1 As New SerialPort
    Dim WithEvents Timer1 As New Timer
    Dim dataQueue As New ConcurrentQueue(Of String)
    Dim partialLine As String = ""

    ' --- Metrics ---
    Dim RPM_C, RPM_L, RPM_R, RPM_CR, RPM_S, Total_Speed, POWER, Steering_A, TEMP, HUMD, PRESS, Distance, actualGearRatio, actualChainRatio As Decimal
    Dim maxspeed As Decimal = -2
    Dim actualgear As Integer
    Dim Limit As Integer = 20
    Dim DTF As Decimal
    Dim settingsForm As New Form2

    ' --- Initialization ---
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialPort1.Close()
        SerialPort1.BaudRate = 115200
        SerialPort1.DataBits = 8
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.Handshake = Handshake.None
        SerialPort1.Encoding = Encoding.UTF8

        Timer1.Interval = 50
        Timer1.Start()

        InitializeChart(Chart1, "SPEED", {"TOTAL SPEED"})
        InitializeChart(Chart2, "POWER", {"POWER", "TARGET POWER"})

        Chart1.ChartAreas(0).AxisY.Maximum = 120
        Chart2.ChartAreas(0).AxisY.Maximum = 450
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
        Dim line As String = Nothing
        If dataQueue.TryDequeue(line) Then
            ProcessLine(line)
        End If
    End Sub

    ' --- Data Processing ---
    Private Sub ProcessLine(line As String)
        If String.IsNullOrEmpty(line) OrElse Not line.Contains(",") Then Return
        Dim s() As String = line.Split(",")
        If s.Length < 27 Then Return

        If Not Decimal.TryParse(s(0), RPM_C) OrElse Not Decimal.TryParse(s(1), RPM_L) OrElse Not Decimal.TryParse(s(2), RPM_R) Then Return
        Decimal.TryParse(s(4), RPM_CR)
        Decimal.TryParse(s(5), Total_Speed)
        Decimal.TryParse(s(18), Distance)
        Decimal.TryParse(s(26), POWER)

        LbPower.Invoke(Sub() LbPower.Text = POWER.ToString())
        UpdateGearChainRatio(RPM_CR, RPM_S, RPM_C)
        UpdateCharts(Total_Speed, POWER)

        ' --- Gear Check ---
        Dim expectedGearRatios As New Dictionary(Of String, Decimal) From {
            {"1.0", 0.35556}, {"2", 0.31111}, {"3.0", 0.27778},
            {"4.0", 0.24444}, {"5.0", 0.22222}, {"6.0", 0.18889}
        }

        Dim gearKey As String = s(7).Trim()
        If expectedGearRatios.ContainsKey(gearKey) Then
            Dim expected = expectedGearRatios(gearKey)
            Dim tolerance = expected * 0.02
            If actualGearRatio < expected - tolerance OrElse actualGearRatio > expected + tolerance Then
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

        ' --- Wheel RPM Comparison ---
        Dim diff1to2 As Decimal = Math.Abs(RPM_C - RPM_L)
        Dim diff2to3 As Decimal = Math.Abs(RPM_L - RPM_R)
        Dim diff1to3 As Decimal = Math.Abs(RPM_C - RPM_R)
        Dim toleranceW = 11D

        If diff1to2 <= toleranceW AndAlso diff2to3 <= toleranceW AndAlso diff1to3 <= toleranceW Then
            GroupBox1.Invoke(Sub() GroupBox1.BackColor = Color.FromArgb(128, 255, 128))
            GroupBox2.Invoke(Sub() GroupBox2.BackColor = Color.FromArgb(128, 255, 128))
            GroupBox3.Invoke(Sub() GroupBox3.BackColor = Color.FromArgb(128, 255, 128))
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

        ' Max speed and UI
        If Total_Speed > maxspeed Then maxspeed = Total_Speed
        Lbmax.Invoke(Sub() Lbmax.Text = $"{maxspeed} KPH")
        LbSpeed2.Invoke(Sub() LbSpeed2.Text = $"{Total_Speed} KPH")
    End Sub

    Private Sub UpdateGearChainRatio(RPM_CR As Decimal, RPM_S As Decimal, RPM_C As Decimal)
        If RPM_S <> 0 AndAlso RPM_C <> 0 Then
            actualChainRatio = RPM_CR / RPM_S
            actualGearRatio = RPM_CR / RPM_C
        End If
    End Sub

    Dim chartTickCounter As Integer = 0
    Private Sub UpdateCharts(speed As Decimal, power As Decimal)
        chartTickCounter += 1
        If chartTickCounter Mod 5 <> 0 Then Return
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

    Private Sub comparsion(actualratio As Decimal)
        If actualratio >= 0.35556 Then actualgear = 1
        If actualratio >= 0.31111 Then actualgear = 2
        If actualratio >= 0.27778 Then actualgear = 3
        If actualratio >= 0.24444 Then actualgear = 4
        If actualratio >= 0.22222 Then actualgear = 5
        If actualratio >= 0.18889 Then actualgear = 6
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
End Class
