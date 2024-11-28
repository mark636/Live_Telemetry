Imports System.IO.Ports
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Linq
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft.Office.Core
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml
Imports System.Text
Imports ClosedXML.Excel
Public Class Form1

    Dim RPM_C As Decimal
    Dim RPM_L As Decimal
    Dim RPM_R As Decimal
    Dim RPM_CR As Decimal
    Dim RPM_S As Decimal
    Dim Total_Speed As Decimal
    Dim POWER As Decimal
    Dim Steering_A As Decimal
    Dim TEMP As Decimal
    Dim HUMD As Decimal
    Dim PRESS As Decimal
    Dim Distance As Decimal
    Dim WithEvents SerialPort1 As New SerialPort
    Dim WithEvents Timer1 As New Timer
    Dim Limit = 20
    Dim actualGearRatio As Decimal
    Dim actualChainRatio As Decimal
    Dim maxspeed = -2
    Dim actualgear As Integer
    Dim serialBuffer As New StringBuilder()
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Initialize And configure the serial port
        SerialPort1.Close()
        SerialPort1.BaudRate = 115200
        SerialPort1.DataBits = 8
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.Handshake = Handshake.None
        SerialPort1.Encoding = System.Text.Encoding.UTF8

        ' Initialize and configure the timer
        Timer1.Interval = 200  ' Set the interval to 100 milliseconds
        Timer1.Start()

        ' Configure Chart1 for Humidity and Temperature
        Chart1.Series.Clear()

        ' Initialize Charts and Series
        InitializeChart(Chart1, "SPEED", {"TOTAL SPEED"})
        InitializeChart(Chart2, "POWER", {"POWER", "TARGET POWER"}) ' Added "TARGET POWER" series

        ' Set Y-axis maximum values
        Chart1.ChartAreas(0).AxisY.Maximum = 120 'SET MAXIMUM VALUE
        Chart2.ChartAreas(0).AxisY.Maximum = 450 ' Set MAXIMUM VALUE
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
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProcessSerialData()
    End Sub
    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            Dim mydata As String = SerialPort1.ReadExisting()
            If TextBox1.InvokeRequired Then
                TextBox1.Invoke(DirectCast(Sub() AppendToBuffer(mydata), MethodInvoker))
            Else
                AppendToBuffer(mydata)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub AppendToBuffer(data As String)
        serialBuffer.Append(data)
    End Sub
    Private Sub ProcessSerialData()
        Dim s As String = serialBuffer.ToString()
        Dim Tolerance As Decimal = 0.02
        Dim WTolerance As Decimal = 11
        Dim expectedGearRatios As New Dictionary(Of String, Double) From {
    {"1.0", 0.35556}, '0.35556
    {"2.0", 0.31111}, '0.31111
    {"3.0", 0.27778},'0.27778
    {"4.0", 0.24444},'0.24444
    {"5.0", 0.22222},'0.22222
    {"6.0", 0.18889} '0.18889  
}
        actualGearRatio = 0.0
        actualChainRatio = 0.0

        ' Check if the string is null or empty
        If String.IsNullOrEmpty(s) Then
            Return
        End If

        ' Split string based on newline
        Dim lines() As String = s.Split(New Char() {ControlChars.Lf})

        ' Process each complete line
        For Each line As String In lines
            If Not String.IsNullOrEmpty(line) AndAlso line.Contains(",") Then
                ' Split string based on comma
                Dim somestring() As String = line.Split(New Char() {","c})
                ' Ensure that the array has at least 2 elements
                If somestring.Length >= 27 Then
                    ' Calculate the differences
                    Dim diff1to2 As Decimal = Math.Abs(somestring(0) - somestring(1))
                    Dim diff2to3 As Decimal = Math.Abs(somestring(1) - somestring(2))
                    Dim diff1to3 As Decimal = Math.Abs(somestring(0) - somestring(2))
                    Dim gear As Decimal = somestring(7).Trim()
                    Dim cranksValue As String = somestring(2).Trim()
                    RPM_CR = Decimal.Parse(somestring(4))
                    RPM_S = Decimal.Parse(somestring(4))
                    RPM_C = Decimal.Parse(somestring(0))
                    Distance = Decimal.Parse(somestring(18))

                    Dim powerValue As String = somestring(26).Trim()
                    If Not String.IsNullOrEmpty(powerValue) AndAlso Decimal.TryParse(powerValue, POWER) Then
                        ' Update label with power value
                        LbPower.Text = POWER.ToString()
                    End If

                    'Update gear ratio
                    UpdateGearChainRatio(RPM_CR, RPM_S, RPM_C)

                    ' Update Charts Efficiently
                    UpdateCharts(Total_Speed, POWER)

                    Dim gearString As String = somestring(7).Trim()
                    ' Attempt to parse the gear value as an Integer
                    If Decimal.TryParse(gearString, gear) Then
                        ' Check if the gear exists in the dictionary
                        If expectedGearRatios.ContainsKey(gear) Then
                            Dim calculatedRatio As Decimal = expectedGearRatios(gear)
                            Dim upperLimit As Decimal = calculatedRatio + (calculatedRatio * Tolerance)
                            Dim lowerLimit As Decimal = calculatedRatio - (calculatedRatio * Tolerance)

                            ' Perform the gear ratio check
                            If actualGearRatio > upperLimit Or actualGearRatio < lowerLimit Then
                                comparsion(actualGearRatio)
                                If Label8.Text <> "GEAR RATIO: " & actualGearRatio.ToString("F2") & " Gear: " & actualgear Then
                                    Label8.Text = "GEAR RATIO: " & actualGearRatio.ToString("F2") & " Gear: " & actualgear
                                End If
                                If GroupBox4.BackColor <> Color.Red Then
                                    GroupBox4.BackColor = Color.Red
                                End If
                            Else
                                If Label8.Text <> "STATUS: OK!" Then
                                    Label8.Text = "STATUS: OK!"
                                End If
                                If GroupBox4.BackColor <> Color.FromArgb(128, 255, 128) Then
                                    GroupBox4.BackColor = Color.FromArgb(128, 255, 128)
                                End If
                            End If
                        Else
                            Debug.WriteLine("Gear not found in the dictionary.")
                        End If
                    Else
                        Debug.WriteLine("Invalid gear data: " & gearString)
                    End If

                    ' Check if the chain might be off
                    Dim upperChainLimit As Decimal = 0.38095 + (0.38095 * Tolerance)
                    Dim lowerChainLimit As Decimal = 0.38095 - (0.38095 * Tolerance)

                    If actualChainRatio > upperChainLimit Or actualChainRatio < lowerChainLimit Then
                        ' Chain might be off - set GroupBox to red
                        If GroupBox5.BackColor <> Color.Red Then
                            GroupBox5.BackColor = Color.Red
                        End If
                        If LbChain.Text <> "CHAIN RATIO: " & actualGearRatio.ToString("F2") Then
                            LbChain.Text = "CHAIN RATIO: " & actualGearRatio.ToString("F2")
                        End If
                    Else
                        ' Chain seems fine - set GroupBox to default color
                        If GroupBox5.BackColor <> Color.FromArgb(128, 255, 128) Then
                            GroupBox5.BackColor = Color.FromArgb(128, 255, 128)
                        End If
                    End If

                    Try
                        Total_Speed = Decimal.Parse(somestring(5))
                        If (Total_Speed > maxspeed) Then
                            maxspeed = Total_Speed
                        End If
                        Lbmax.Text = maxspeed.ToString() & " KPH"
                        LbSpeed2.Text = Total_Speed & " KPH"
                    Catch ex As Exception
                        Continue For
                    End Try

                    'SENSOR STATUS
                    UpdateLabelBasedOnValue(somestring(0).Trim(), LbSenRPMC, "RPM_CENTRE: DISCONNECTED")
                    UpdateLabelBasedOnValue(somestring(1).Trim(), LbSenRPML, "RPM_LEFT: DISCONNECTED")
                    UpdateLabelBasedOnValue(somestring(2).Trim(), LbSenRPMR, "RPM_RIGHT: DISCONNECTED")
                    UpdateLabelBasedOnValue(somestring(3).Trim(), LbSenCrank, "RPM_RIGHT: DISCONNECTED")
                    UpdateLabelBasedOnValue(somestring(4).Trim(), lbSenShaft, "RPM_RIGHT: DISCONNECTED")

                    If somestring(15).Trim() = "0.0" And somestring(16).Trim() = "0.0" And somestring(16).Trim() = "0.0" Then
                        lbENVSen.Text = "ENVIRONMENTAL: DISCONNECTED"
                        lbENVSen.ForeColor = Color.Red
                    Else
                        lbENVSen.ForeColor = Color.FromArgb(128, 255, 128)
                    End If

                    ' Determine if all wheels are within the tolerance
                    If diff1to2 <= WTolerance AndAlso diff2to3 <= WTolerance AndAlso diff1to3 <= WTolerance Then
                        ' All wheels are within tolerance - set all GroupBoxes to default color
                        GroupBox1.BackColor = Color.FromArgb(128, 255, 128)
                        GroupBox2.BackColor = Color.FromArgb(128, 255, 128)
                        GroupBox3.BackColor = Color.FromArgb(128, 255, 128)
                        updateLabel(Label7, "STATUS: OK!!!!!")
                        updateLabel(Label6, "STATUS: OK!")
                        updateLabel(Label4, "STATUS: OK!")
                    Else
                        ' At least one pair of wheels is outside the tolerance - highlight the differing GroupBoxes
                        If diff1to2 > WTolerance And diff1to3 > WTolerance Then
                            GroupBox1.BackColor = Color.Red
                            Label4.Text = "diff1to2: " & diff1to2.ToString("F2") & ", diff1to3: " & diff1to3.ToString("F2")
                        Else
                            GroupBox1.ForeColor = Color.Black
                        End If

                        If diff1to2 > WTolerance And diff2to3 > WTolerance Then
                            GroupBox2.BackColor = Color.Red
                            Label6.Text = "diff1to2: " & diff1to2.ToString("F2") & ", diff2to3: " & diff2to3.ToString("F2")
                        Else
                            GroupBox2.ForeColor = Color.Black
                        End If

                        If diff1to3 > WTolerance And diff2to3 > WTolerance Then
                            GroupBox3.BackColor = Color.Red
                            Label7.Text = "diff1to3: " & diff1to3.ToString("F2") & ", diff2to3: " & diff2to3.ToString("F2")
                        Else
                            GroupBox3.ForeColor = Color.Black
                        End If
                    End If

                    'GEAR Label
                    LbGear2.Text = somestring(7)

                    'Battery_Gear
                    LbBatG.Text = somestring(8)
                    LbBatteryPi.Text = somestring(18)
                    LbAnalog.Text = somestring(19)

                    'Cadence
                    LbCranks.Text = cranksValue

                    'Distance to Finish
                    Dim DTF As Decimal
                    DTF = 8046.72 - Distance
                    LbDist.Text = DTF

                    ' Target Power Calculation
                    Dim targetPower As Integer
                    If Distance >= 0 And Distance <= 1500 Then
                        targetPower = 90
                    ElseIf Distance >= 1500 And Distance < 2000 Then
                        targetPower = 110
                    ElseIf Distance >= 2000 And Distance < 2500 Then
                        targetPower = 150
                    ElseIf Distance >= 2500 And Distance < 3000 Then
                        targetPower = 200
                    ElseIf Distance >= 3000 And Distance < 3500 Then
                        targetPower = 250
                    ElseIf Distance >= 3500 Then
                        targetPower = 300
                    End If
                    TargetPWR.Text = targetPower.ToString()
                End If
            End If
        Next
        ' Remove processed data from the buffer
        If lines.Length > 1 Then
            serialBuffer.Clear()
            serialBuffer.Append(lines.Last())
        End If
    End Sub
    Private Sub updateLabel(ByVal label As Label, contentLabel As String)
        label.Text = contentLabel
    End Sub
    Private Sub UpdateLabelBasedOnValue(ByVal inputString As String, ByVal label As Label, ByVal disconnectedText As String)
        If inputString.Trim() = "0.0" Then
            label.Text = disconnectedText
            label.ForeColor = Color.Red
        Else
            label.ForeColor = Color.FromArgb(128, 255, 128)
        End If
    End Sub
    Private Sub UpdateGearChainRatio(RPM_CR As Decimal, RPM_S As Decimal, RPM_C As Decimal)
        ' Check if the denominator (RPM_S or RPM_C) is zero before performing division
        If RPM_S <> 0 AndAlso RPM_C <> 0 Then
            ' Perform the calculations if the values are valid
            Dim chainRatio As Decimal = RPM_CR / RPM_S
            Dim gearRatio As Decimal = RPM_CR / RPM_C
        End If
    End Sub

    Private Sub UpdateCharts(speed As Decimal, power As Decimal)
        Chart1.Series("TOTAL SPEED").Points.AddY(speed)
        Chart2.Series("POWER").Points.AddY(power)

        If Chart1.Series("TOTAL SPEED").Points.Count > Limit Then
            Chart1.Series("TOTAL SPEED").Points.RemoveAt(0)
        End If
        If Chart2.Series("POWER").Points.Count > Limit Then
            Chart2.Series("POWER").Points.RemoveAt(0)
        End If
    End Sub
    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        SerialPort1.Close()
        Timer1.Stop()
    End Sub
    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Sub comparsion(actualratio As Decimal)
        If actualratio >= 0.35556 Then
            actualgear = 1
        ElseIf actualratio >= 0.3111 Then
            actualgear = 2
        ElseIf actualratio >= 0.27778 Then
            actualgear = 3
        ElseIf actualratio >= 0.24444 Then
            actualgear = 4
        ElseIf actualratio >= 0.22222 Then
            actualgear = 5
        ElseIf actualratio >= 0.18889 Then
            actualgear = 6
        End If
    End Sub
    Private Sub ButtonScanPort_Click(sender As Object, e As EventArgs) Handles ButtonScanPort.Click
        ComboBoxPort.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBoxPort.Items.AddRange(myPort)
        i = ComboBoxPort.Items.Count
        i = i - i
        Try
            ComboBoxPort.SelectedIndex = i
            ButtonConnect.Enabled = True
        Catch ex As Exception
            MsgBox("Com port not detected", MsgBoxStyle.Critical, "Warning !!!")
            ComboBoxPort.Text = ""
            ComboBoxPort.Items.Clear()
            Return
        End Try
        ComboBoxPort.DroppedDown = True
    End Sub
    'Crashing when nothing is in menu strip and connect button is pressed twice
    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        SerialPort1.PortName = ComboBoxPort.SelectedItem
        SerialPort1.Open()
        Timer1.Start()
    End Sub
End Class