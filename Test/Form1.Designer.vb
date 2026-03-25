<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.ButtonScanPort = New System.Windows.Forms.Button()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LbSenPH = New System.Windows.Forms.Label()
        Me.LbSenRl = New System.Windows.Forms.Label()
        Me.LbSenYW = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LbGear2 = New System.Windows.Forms.Label()
        Me.LbAnalog = New System.Windows.Forms.Label()
        Me.Lab = New System.Windows.Forms.Label()
        Me.LbBatteryPi = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LbBatG = New System.Windows.Forms.Label()
        Me.Lbmax = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button_GearReset = New System.Windows.Forms.Button()
        Me.TextBox_Gear6_Display = New System.Windows.Forms.TextBox()
        Me.TextBox_Gear5_Display = New System.Windows.Forms.TextBox()
        Me.TextBox_Gear4_Display = New System.Windows.Forms.TextBox()
        Me.TextBox_Gear3_Display = New System.Windows.Forms.TextBox()
        Me.TextBox_Gear2_Display = New System.Windows.Forms.TextBox()
        Me.TextBox_Gear1_Display = New System.Windows.Forms.TextBox()
        Me.Button_GearSubmit = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox_Gear6 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox_Gear5 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox_Gear4 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox_Gear3 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox_Gear2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox_Gear1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbLaps = New System.Windows.Forms.ListBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnStartStop = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.LbCranks = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LbSpeed2 = New System.Windows.Forms.Label()
        Me.LbSpeed = New System.Windows.Forms.Label()
        Me.LbPower = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LbChain = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnDisconnect
        '
        Me.btnDisconnect.FlatAppearance.BorderSize = 0
        Me.btnDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisconnect.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisconnect.ForeColor = System.Drawing.Color.Transparent
        Me.btnDisconnect.Location = New System.Drawing.Point(100, 50)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(124, 32)
        Me.btnDisconnect.TabIndex = 9
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(100, 19)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxPort.TabIndex = 10
        '
        'ButtonScanPort
        '
        Me.ButtonScanPort.FlatAppearance.BorderSize = 0
        Me.ButtonScanPort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ButtonScanPort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ButtonScanPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonScanPort.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScanPort.ForeColor = System.Drawing.Color.Transparent
        Me.ButtonScanPort.Location = New System.Drawing.Point(19, 17)
        Me.ButtonScanPort.Name = "ButtonScanPort"
        Me.ButtonScanPort.Size = New System.Drawing.Size(75, 26)
        Me.ButtonScanPort.TabIndex = 11
        Me.ButtonScanPort.Text = "Scan port"
        Me.ButtonScanPort.UseVisualStyleBackColor = True
        '
        'ButtonConnect
        '
        Me.ButtonConnect.FlatAppearance.BorderSize = 0
        Me.ButtonConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ButtonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConnect.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConnect.ForeColor = System.Drawing.Color.Transparent
        Me.ButtonConnect.Location = New System.Drawing.Point(19, 50)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(75, 32)
        Me.ButtonConnect.TabIndex = 12
        Me.ButtonConnect.Text = "Connect"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(1075, 551)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 21)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "BIKE ORIENTATION"
        '
        'LbSenPH
        '
        Me.LbSenPH.AutoSize = True
        Me.LbSenPH.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSenPH.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LbSenPH.Location = New System.Drawing.Point(1111, 595)
        Me.LbSenPH.Name = "LbSenPH"
        Me.LbSenPH.Size = New System.Drawing.Size(49, 21)
        Me.LbSenPH.TabIndex = 56
        Me.LbSenPH.Text = "Pitch"
        '
        'LbSenRl
        '
        Me.LbSenRl.AutoSize = True
        Me.LbSenRl.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSenRl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LbSenRl.Location = New System.Drawing.Point(933, 595)
        Me.LbSenRl.Name = "LbSenRl"
        Me.LbSenRl.Size = New System.Drawing.Size(40, 21)
        Me.LbSenRl.TabIndex = 58
        Me.LbSenRl.Text = "Roll"
        '
        'LbSenYW
        '
        Me.LbSenYW.AutoSize = True
        Me.LbSenYW.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSenYW.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LbSenYW.Location = New System.Drawing.Point(1282, 595)
        Me.LbSenYW.Name = "LbSenYW"
        Me.LbSenYW.Size = New System.Drawing.Size(40, 21)
        Me.LbSenYW.TabIndex = 57
        Me.LbSenYW.Text = "Yaw"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.LbGear2)
        Me.Panel2.Controls.Add(Me.LbAnalog)
        Me.Panel2.Controls.Add(Me.Lab)
        Me.Panel2.Controls.Add(Me.LbBatteryPi)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.LbBatG)
        Me.Panel2.Controls.Add(Me.Lbmax)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.ButtonConnect)
        Me.Panel2.Controls.Add(Me.btnDisconnect)
        Me.Panel2.Controls.Add(Me.ComboBoxPort)
        Me.Panel2.Controls.Add(Me.ButtonScanPort)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1603, 98)
        Me.Panel2.TabIndex = 65
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(1192, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 28)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "BatteryGear:"
        '
        'LbGear2
        '
        Me.LbGear2.AutoSize = True
        Me.LbGear2.BackColor = System.Drawing.Color.Transparent
        Me.LbGear2.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGear2.ForeColor = System.Drawing.Color.Transparent
        Me.LbGear2.Location = New System.Drawing.Point(400, 19)
        Me.LbGear2.Name = "LbGear2"
        Me.LbGear2.Size = New System.Drawing.Size(24, 28)
        Me.LbGear2.TabIndex = 74
        Me.LbGear2.Text = "0"
        '
        'LbAnalog
        '
        Me.LbAnalog.AutoSize = True
        Me.LbAnalog.BackColor = System.Drawing.Color.Transparent
        Me.LbAnalog.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAnalog.ForeColor = System.Drawing.Color.Transparent
        Me.LbAnalog.Location = New System.Drawing.Point(1085, 19)
        Me.LbAnalog.Name = "LbAnalog"
        Me.LbAnalog.Size = New System.Drawing.Size(24, 28)
        Me.LbAnalog.TabIndex = 73
        Me.LbAnalog.Text = "0"
        '
        'Lab
        '
        Me.Lab.AutoSize = True
        Me.Lab.BackColor = System.Drawing.Color.Transparent
        Me.Lab.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab.ForeColor = System.Drawing.Color.Transparent
        Me.Lab.Location = New System.Drawing.Point(935, 19)
        Me.Lab.Name = "Lab"
        Me.Lab.Size = New System.Drawing.Size(155, 28)
        Me.Lab.TabIndex = 72
        Me.Lab.Text = "BatteryAnalog:"
        '
        'LbBatteryPi
        '
        Me.LbBatteryPi.AutoSize = True
        Me.LbBatteryPi.BackColor = System.Drawing.Color.Transparent
        Me.LbBatteryPi.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBatteryPi.ForeColor = System.Drawing.Color.Transparent
        Me.LbBatteryPi.Location = New System.Drawing.Point(860, 19)
        Me.LbBatteryPi.Name = "LbBatteryPi"
        Me.LbBatteryPi.Size = New System.Drawing.Size(24, 28)
        Me.LbBatteryPi.TabIndex = 71
        Me.LbBatteryPi.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(742, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 28)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "BatteryPI:"
        '
        'LbBatG
        '
        Me.LbBatG.AutoSize = True
        Me.LbBatG.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.LbBatG.Location = New System.Drawing.Point(1322, 19)
        Me.LbBatG.Name = "LbBatG"
        Me.LbBatG.Size = New System.Drawing.Size(24, 28)
        Me.LbBatG.TabIndex = 69
        Me.LbBatG.Text = "0"
        '
        'Lbmax
        '
        Me.Lbmax.AutoSize = True
        Me.Lbmax.BackColor = System.Drawing.Color.Transparent
        Me.Lbmax.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbmax.ForeColor = System.Drawing.Color.Transparent
        Me.Lbmax.Location = New System.Drawing.Point(586, 19)
        Me.Lbmax.Name = "Lbmax"
        Me.Lbmax.Size = New System.Drawing.Size(24, 28)
        Me.Lbmax.TabIndex = 68
        Me.Lbmax.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(328, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 28)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "GEAR:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(445, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 28)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "MAX SPEED:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button_GearReset)
        Me.Panel3.Controls.Add(Me.TextBox_Gear6_Display)
        Me.Panel3.Controls.Add(Me.TextBox_Gear5_Display)
        Me.Panel3.Controls.Add(Me.TextBox_Gear4_Display)
        Me.Panel3.Controls.Add(Me.TextBox_Gear3_Display)
        Me.Panel3.Controls.Add(Me.TextBox_Gear2_Display)
        Me.Panel3.Controls.Add(Me.TextBox_Gear1_Display)
        Me.Panel3.Controls.Add(Me.Button_GearSubmit)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.TextBox_Gear6)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.TextBox_Gear5)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.TextBox_Gear4)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.TextBox_Gear3)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.TextBox_Gear2)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.TextBox_Gear1)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.LbSenYW)
        Me.Panel3.Controls.Add(Me.LbSenPH)
        Me.Panel3.Controls.Add(Me.LbSenRl)
        Me.Panel3.Controls.Add(Me.lbLaps)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.btnReset)
        Me.Panel3.Controls.Add(Me.btnStartStop)
        Me.Panel3.Controls.Add(Me.lblTime)
        Me.Panel3.Controls.Add(Me.LbCranks)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.LbSpeed2)
        Me.Panel3.Controls.Add(Me.LbSpeed)
        Me.Panel3.Controls.Add(Me.LbPower)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Chart2)
        Me.Panel3.Controls.Add(Me.GroupBox5)
        Me.Panel3.Controls.Add(Me.GroupBox4)
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Chart1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 98)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1603, 676)
        Me.Panel3.TabIndex = 66
        '
        'Button_GearReset
        '
        Me.Button_GearReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_GearReset.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button_GearReset.Location = New System.Drawing.Point(1493, 223)
        Me.Button_GearReset.Name = "Button_GearReset"
        Me.Button_GearReset.Size = New System.Drawing.Size(61, 20)
        Me.Button_GearReset.TabIndex = 109
        Me.Button_GearReset.Text = "Reset"
        Me.Button_GearReset.UseVisualStyleBackColor = True
        '
        'TextBox_Gear6_Display
        '
        Me.TextBox_Gear6_Display.BackColor = System.Drawing.Color.SlateBlue
        Me.TextBox_Gear6_Display.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Gear6_Display.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox_Gear6_Display.Location = New System.Drawing.Point(1493, 197)
        Me.TextBox_Gear6_Display.Name = "TextBox_Gear6_Display"
        Me.TextBox_Gear6_Display.ReadOnly = True
        Me.TextBox_Gear6_Display.Size = New System.Drawing.Size(61, 20)
        Me.TextBox_Gear6_Display.TabIndex = 108
        '
        'TextBox_Gear5_Display
        '
        Me.TextBox_Gear5_Display.BackColor = System.Drawing.Color.SlateBlue
        Me.TextBox_Gear5_Display.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Gear5_Display.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox_Gear5_Display.Location = New System.Drawing.Point(1493, 171)
        Me.TextBox_Gear5_Display.Name = "TextBox_Gear5_Display"
        Me.TextBox_Gear5_Display.ReadOnly = True
        Me.TextBox_Gear5_Display.Size = New System.Drawing.Size(61, 20)
        Me.TextBox_Gear5_Display.TabIndex = 107
        '
        'TextBox_Gear4_Display
        '
        Me.TextBox_Gear4_Display.BackColor = System.Drawing.Color.SlateBlue
        Me.TextBox_Gear4_Display.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Gear4_Display.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox_Gear4_Display.Location = New System.Drawing.Point(1493, 145)
        Me.TextBox_Gear4_Display.Name = "TextBox_Gear4_Display"
        Me.TextBox_Gear4_Display.ReadOnly = True
        Me.TextBox_Gear4_Display.Size = New System.Drawing.Size(61, 20)
        Me.TextBox_Gear4_Display.TabIndex = 106
        '
        'TextBox_Gear3_Display
        '
        Me.TextBox_Gear3_Display.BackColor = System.Drawing.Color.SlateBlue
        Me.TextBox_Gear3_Display.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Gear3_Display.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox_Gear3_Display.Location = New System.Drawing.Point(1493, 119)
        Me.TextBox_Gear3_Display.Name = "TextBox_Gear3_Display"
        Me.TextBox_Gear3_Display.ReadOnly = True
        Me.TextBox_Gear3_Display.Size = New System.Drawing.Size(61, 20)
        Me.TextBox_Gear3_Display.TabIndex = 105
        '
        'TextBox_Gear2_Display
        '
        Me.TextBox_Gear2_Display.BackColor = System.Drawing.Color.SlateBlue
        Me.TextBox_Gear2_Display.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Gear2_Display.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox_Gear2_Display.Location = New System.Drawing.Point(1493, 93)
        Me.TextBox_Gear2_Display.Name = "TextBox_Gear2_Display"
        Me.TextBox_Gear2_Display.ReadOnly = True
        Me.TextBox_Gear2_Display.Size = New System.Drawing.Size(61, 20)
        Me.TextBox_Gear2_Display.TabIndex = 104
        '
        'TextBox_Gear1_Display
        '
        Me.TextBox_Gear1_Display.BackColor = System.Drawing.Color.SlateBlue
        Me.TextBox_Gear1_Display.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Gear1_Display.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox_Gear1_Display.Location = New System.Drawing.Point(1493, 67)
        Me.TextBox_Gear1_Display.Name = "TextBox_Gear1_Display"
        Me.TextBox_Gear1_Display.ReadOnly = True
        Me.TextBox_Gear1_Display.Size = New System.Drawing.Size(61, 20)
        Me.TextBox_Gear1_Display.TabIndex = 103
        '
        'Button_GearSubmit
        '
        Me.Button_GearSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_GearSubmit.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button_GearSubmit.Location = New System.Drawing.Point(1426, 223)
        Me.Button_GearSubmit.Name = "Button_GearSubmit"
        Me.Button_GearSubmit.Size = New System.Drawing.Size(61, 20)
        Me.Button_GearSubmit.TabIndex = 102
        Me.Button_GearSubmit.Text = "Submit"
        Me.Button_GearSubmit.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.Location = New System.Drawing.Point(1399, 197)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(21, 19)
        Me.Label20.TabIndex = 101
        Me.Label20.Text = "6:"
        '
        'TextBox_Gear6
        '
        Me.TextBox_Gear6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Gear6.Location = New System.Drawing.Point(1426, 197)
        Me.TextBox_Gear6.Name = "TextBox_Gear6"
        Me.TextBox_Gear6.Size = New System.Drawing.Size(61, 20)
        Me.TextBox_Gear6.TabIndex = 100
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(1399, 171)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(21, 19)
        Me.Label19.TabIndex = 99
        Me.Label19.Text = "5:"
        '
        'TextBox_Gear5
        '
        Me.TextBox_Gear5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Gear5.Location = New System.Drawing.Point(1426, 171)
        Me.TextBox_Gear5.Name = "TextBox_Gear5"
        Me.TextBox_Gear5.Size = New System.Drawing.Size(61, 20)
        Me.TextBox_Gear5.TabIndex = 98
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(1399, 145)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(21, 19)
        Me.Label18.TabIndex = 97
        Me.Label18.Text = "4:"
        '
        'TextBox_Gear4
        '
        Me.TextBox_Gear4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Gear4.Location = New System.Drawing.Point(1426, 145)
        Me.TextBox_Gear4.Name = "TextBox_Gear4"
        Me.TextBox_Gear4.Size = New System.Drawing.Size(61, 20)
        Me.TextBox_Gear4.TabIndex = 96
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(1399, 119)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(21, 19)
        Me.Label17.TabIndex = 95
        Me.Label17.Text = "3:"
        '
        'TextBox_Gear3
        '
        Me.TextBox_Gear3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Gear3.Location = New System.Drawing.Point(1426, 119)
        Me.TextBox_Gear3.Name = "TextBox_Gear3"
        Me.TextBox_Gear3.Size = New System.Drawing.Size(61, 20)
        Me.TextBox_Gear3.TabIndex = 94
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(1399, 93)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(21, 19)
        Me.Label16.TabIndex = 93
        Me.Label16.Text = "2:"
        '
        'TextBox_Gear2
        '
        Me.TextBox_Gear2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Gear2.Location = New System.Drawing.Point(1426, 93)
        Me.TextBox_Gear2.Name = "TextBox_Gear2"
        Me.TextBox_Gear2.Size = New System.Drawing.Size(61, 20)
        Me.TextBox_Gear2.TabIndex = 92
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(1399, 67)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 19)
        Me.Label15.TabIndex = 91
        Me.Label15.Text = "1:"
        '
        'TextBox_Gear1
        '
        Me.TextBox_Gear1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox_Gear1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Gear1.Location = New System.Drawing.Point(1426, 67)
        Me.TextBox_Gear1.Name = "TextBox_Gear1"
        Me.TextBox_Gear1.Size = New System.Drawing.Size(61, 20)
        Me.TextBox_Gear1.TabIndex = 90
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(1405, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(126, 28)
        Me.Label14.TabIndex = 89
        Me.Label14.Text = "Gear Ratios:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1407, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 13)
        Me.Label12.TabIndex = 88
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(188, 551)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 21)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "STOPWATCH"
        '
        'lbLaps
        '
        Me.lbLaps.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.lbLaps.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbLaps.Font = New System.Drawing.Font("Nirmala UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbLaps.ForeColor = System.Drawing.Color.White
        Me.lbLaps.FormattingEnabled = True
        Me.lbLaps.ItemHeight = 20
        Me.lbLaps.Location = New System.Drawing.Point(429, 578)
        Me.lbLaps.Margin = New System.Windows.Forms.Padding(2)
        Me.lbLaps.Name = "lbLaps"
        Me.lbLaps.Size = New System.Drawing.Size(357, 60)
        Me.lbLaps.TabIndex = 86
        '
        'btnReset
        '
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Transparent
        Me.btnReset.Location = New System.Drawing.Point(302, 587)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(92, 32)
        Me.btnReset.TabIndex = 85
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnStartStop
        '
        Me.btnStartStop.FlatAppearance.BorderSize = 0
        Me.btnStartStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartStop.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartStop.ForeColor = System.Drawing.Color.Transparent
        Me.btnStartStop.Location = New System.Drawing.Point(191, 587)
        Me.btnStartStop.Name = "btnStartStop"
        Me.btnStartStop.Size = New System.Drawing.Size(96, 32)
        Me.btnStartStop.TabIndex = 84
        Me.btnStartStop.Text = "Start"
        Me.btnStartStop.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblTime.Location = New System.Drawing.Point(25, 586)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(106, 28)
        Me.lblTime.TabIndex = 83
        Me.lblTime.Text = "00.00.000"
        '
        'LbCranks
        '
        Me.LbCranks.AutoSize = True
        Me.LbCranks.BackColor = System.Drawing.Color.Transparent
        Me.LbCranks.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCranks.ForeColor = System.Drawing.Color.Transparent
        Me.LbCranks.Location = New System.Drawing.Point(698, 25)
        Me.LbCranks.Name = "LbCranks"
        Me.LbCranks.Size = New System.Drawing.Size(24, 28)
        Me.LbCranks.TabIndex = 82
        Me.LbCranks.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(609, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 28)
        Me.Label13.TabIndex = 81
        Me.Label13.Text = "Cadence:"
        '
        'LbSpeed2
        '
        Me.LbSpeed2.AutoSize = True
        Me.LbSpeed2.BackColor = System.Drawing.Color.Transparent
        Me.LbSpeed2.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSpeed2.ForeColor = System.Drawing.Color.Transparent
        Me.LbSpeed2.Location = New System.Drawing.Point(310, 25)
        Me.LbSpeed2.Name = "LbSpeed2"
        Me.LbSpeed2.Size = New System.Drawing.Size(24, 28)
        Me.LbSpeed2.TabIndex = 78
        Me.LbSpeed2.Text = "0"
        '
        'LbSpeed
        '
        Me.LbSpeed.AutoSize = True
        Me.LbSpeed.BackColor = System.Drawing.Color.Transparent
        Me.LbSpeed.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSpeed.ForeColor = System.Drawing.Color.Transparent
        Me.LbSpeed.Location = New System.Drawing.Point(233, 25)
        Me.LbSpeed.Name = "LbSpeed"
        Me.LbSpeed.Size = New System.Drawing.Size(77, 28)
        Me.LbSpeed.TabIndex = 77
        Me.LbSpeed.Text = "SPEED:"
        '
        'LbPower
        '
        Me.LbPower.AutoSize = True
        Me.LbPower.BackColor = System.Drawing.Color.Transparent
        Me.LbPower.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPower.ForeColor = System.Drawing.Color.Transparent
        Me.LbPower.Location = New System.Drawing.Point(1040, 25)
        Me.LbPower.Name = "LbPower"
        Me.LbPower.Size = New System.Drawing.Size(24, 28)
        Me.LbPower.TabIndex = 76
        Me.LbPower.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(952, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 28)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "POWER:"
        '
        'Chart2
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend1)
        Me.Chart2.Location = New System.Drawing.Point(703, 57)
        Me.Chart2.Name = "Chart2"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart2.Series.Add(Series1)
        Me.Chart2.Size = New System.Drawing.Size(616, 358)
        Me.Chart2.TabIndex = 67
        Me.Chart2.Text = "Chart2"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.LbChain)
        Me.GroupBox5.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(1119, 440)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox5.TabIndex = 63
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Rear Ratio"
        '
        'LbChain
        '
        Me.LbChain.AutoSize = True
        Me.LbChain.Font = New System.Drawing.Font("Nirmala UI", 11.25!)
        Me.LbChain.ForeColor = System.Drawing.Color.Black
        Me.LbChain.Location = New System.Drawing.Point(6, 43)
        Me.LbChain.Name = "LbChain"
        Me.LbChain.Size = New System.Drawing.Size(86, 20)
        Me.LbChain.TabIndex = 4
        Me.LbChain.Text = "STATUS: OK"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(835, 440)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox4.TabIndex = 64
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GEAR"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 11.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(6, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 20)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "STATUS: OK"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(546, 440)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 65
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RPM RIGHT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "STATUS: OK"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(281, 440)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RPM LEFT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 11.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "STATUS: OK"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(21, 440)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RPM CENTRE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 11.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(5, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "STATUS: OK"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(776, 193)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(458, 20)
        Me.TextBox1.TabIndex = 58
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(21, 57)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(600, 358)
        Me.Chart1.TabIndex = 59
        Me.Chart1.Text = "Chart1"
        '
        'Timer2
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1603, 774)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MQ SPEED TELEMETRY"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnDisconnect As Button
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents ButtonScanPort As Button
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents LbSenPH As Label
    Friend WithEvents LbSenRl As Label
    Friend WithEvents LbSenYW As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents LbChain As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents LbAnalog As Label
    Friend WithEvents Lab As Label
    Friend WithEvents LbBatteryPi As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LbBatG As Label
    Friend WithEvents Lbmax As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LbGear2 As Label
    Friend WithEvents LbPower As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LbSpeed2 As Label
    Friend WithEvents LbSpeed As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LbCranks As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbLaps As ListBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnStartStop As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox_Gear1 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Button_GearSubmit As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBox_Gear6 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox_Gear5 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox_Gear4 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox_Gear3 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox_Gear2 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox_Gear6_Display As TextBox
    Friend WithEvents TextBox_Gear5_Display As TextBox
    Friend WithEvents TextBox_Gear4_Display As TextBox
    Friend WithEvents TextBox_Gear3_Display As TextBox
    Friend WithEvents TextBox_Gear2_Display As TextBox
    Friend WithEvents TextBox_Gear1_Display As TextBox
    Friend WithEvents Button_GearReset As Button
End Class
