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
        Me.LbSenRPML = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.lbENVSen = New System.Windows.Forms.Label()
        Me.lbSenShaft = New System.Windows.Forms.Label()
        Me.LbSenCrank = New System.Windows.Forms.Label()
        Me.LbSenRPMC = New System.Windows.Forms.Label()
        Me.LbSenRPMR = New System.Windows.Forms.Label()
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
        Me.LbGear = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LbCranks = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TargetPWR = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LbDist = New System.Windows.Forms.Label()
        Me.LbSpeed2 = New System.Windows.Forms.Label()
        Me.LbSpeed = New System.Windows.Forms.Label()
        Me.LbPower = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.Panel1.SuspendLayout()
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
        Me.btnDisconnect.Location = New System.Drawing.Point(133, 62)
        Me.btnDisconnect.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(165, 39)
        Me.btnDisconnect.TabIndex = 9
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(133, 23)
        Me.ComboBoxPort.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(160, 24)
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
        Me.ButtonScanPort.Location = New System.Drawing.Point(25, 21)
        Me.ButtonScanPort.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonScanPort.Name = "ButtonScanPort"
        Me.ButtonScanPort.Size = New System.Drawing.Size(100, 32)
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
        Me.ButtonConnect.Location = New System.Drawing.Point(25, 62)
        Me.ButtonConnect.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(100, 39)
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
        Me.Label5.Location = New System.Drawing.Point(87, 32)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 28)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "SENSOR STATUS:"
        '
        'LbSenRPML
        '
        Me.LbSenRPML.AutoSize = True
        Me.LbSenRPML.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSenRPML.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LbSenRPML.Location = New System.Drawing.Point(29, 164)
        Me.LbSenRPML.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbSenRPML.Name = "LbSenRPML"
        Me.LbSenRPML.Size = New System.Drawing.Size(86, 23)
        Me.LbSenRPML.TabIndex = 56
        Me.LbSenRPML.Text = "RPM_LEFT"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnSettings)
        Me.Panel1.Controls.Add(Me.lbENVSen)
        Me.Panel1.Controls.Add(Me.lbSenShaft)
        Me.Panel1.Controls.Add(Me.LbSenCrank)
        Me.Panel1.Controls.Add(Me.LbSenRPMC)
        Me.Panel1.Controls.Add(Me.LbSenRPMR)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.LbSenRPML)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Location = New System.Drawing.Point(1523, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(313, 918)
        Me.Panel1.TabIndex = 58
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.Transparent
        Me.btnSettings.Location = New System.Drawing.Point(69, 833)
        Me.btnSettings.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(165, 39)
        Me.btnSettings.TabIndex = 65
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'lbENVSen
        '
        Me.lbENVSen.AutoSize = True
        Me.lbENVSen.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbENVSen.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbENVSen.Location = New System.Drawing.Point(29, 438)
        Me.lbENVSen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbENVSen.Name = "lbENVSen"
        Me.lbENVSen.Size = New System.Drawing.Size(216, 23)
        Me.lbENVSen.TabIndex = 63
        Me.lbENVSen.Text = "ENVIRONMENTAL SENSOR"
        '
        'lbSenShaft
        '
        Me.lbSenShaft.AutoSize = True
        Me.lbSenShaft.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSenShaft.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbSenShaft.Location = New System.Drawing.Point(29, 361)
        Me.lbSenShaft.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbSenShaft.Name = "lbSenShaft"
        Me.lbSenShaft.Size = New System.Drawing.Size(101, 23)
        Me.lbSenShaft.TabIndex = 60
        Me.lbSenShaft.Text = "RPM_SHAFT"
        '
        'LbSenCrank
        '
        Me.LbSenCrank.AutoSize = True
        Me.LbSenCrank.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSenCrank.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LbSenCrank.Location = New System.Drawing.Point(29, 290)
        Me.LbSenCrank.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbSenCrank.Name = "LbSenCrank"
        Me.LbSenCrank.Size = New System.Drawing.Size(107, 23)
        Me.LbSenCrank.TabIndex = 59
        Me.LbSenCrank.Text = "RPM_CRANK"
        '
        'LbSenRPMC
        '
        Me.LbSenRPMC.AutoSize = True
        Me.LbSenRPMC.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSenRPMC.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LbSenRPMC.Location = New System.Drawing.Point(29, 100)
        Me.LbSenRPMC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbSenRPMC.Name = "LbSenRPMC"
        Me.LbSenRPMC.Size = New System.Drawing.Size(113, 23)
        Me.LbSenRPMC.TabIndex = 58
        Me.LbSenRPMC.Text = "RPM_CENTRE"
        '
        'LbSenRPMR
        '
        Me.LbSenRPMR.AutoSize = True
        Me.LbSenRPMR.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSenRPMR.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LbSenRPMR.Location = New System.Drawing.Point(29, 225)
        Me.LbSenRPMR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbSenRPMR.Name = "LbSenRPMR"
        Me.LbSenRPMR.Size = New System.Drawing.Size(100, 23)
        Me.LbSenRPMR.TabIndex = 57
        Me.LbSenRPMR.Text = "RPM_RIGHT"
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
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1523, 121)
        Me.Panel2.TabIndex = 65
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(1215, 47)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(165, 35)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "BatteryGear:"
        '
        'LbGear2
        '
        Me.LbGear2.AutoSize = True
        Me.LbGear2.BackColor = System.Drawing.Color.Transparent
        Me.LbGear2.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGear2.ForeColor = System.Drawing.Color.Transparent
        Me.LbGear2.Location = New System.Drawing.Point(536, 16)
        Me.LbGear2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbGear2.Name = "LbGear2"
        Me.LbGear2.Size = New System.Drawing.Size(29, 35)
        Me.LbGear2.TabIndex = 74
        Me.LbGear2.Text = "0"
        '
        'LbAnalog
        '
        Me.LbAnalog.AutoSize = True
        Me.LbAnalog.BackColor = System.Drawing.Color.Transparent
        Me.LbAnalog.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAnalog.ForeColor = System.Drawing.Color.Transparent
        Me.LbAnalog.Location = New System.Drawing.Point(1073, 66)
        Me.LbAnalog.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbAnalog.Name = "LbAnalog"
        Me.LbAnalog.Size = New System.Drawing.Size(29, 35)
        Me.LbAnalog.TabIndex = 73
        Me.LbAnalog.Text = "0"
        '
        'Lab
        '
        Me.Lab.AutoSize = True
        Me.Lab.BackColor = System.Drawing.Color.Transparent
        Me.Lab.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab.ForeColor = System.Drawing.Color.Transparent
        Me.Lab.Location = New System.Drawing.Point(872, 66)
        Me.Lab.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lab.Name = "Lab"
        Me.Lab.Size = New System.Drawing.Size(192, 35)
        Me.Lab.TabIndex = 72
        Me.Lab.Text = "BatteryAnalog:"
        '
        'LbBatteryPi
        '
        Me.LbBatteryPi.AutoSize = True
        Me.LbBatteryPi.BackColor = System.Drawing.Color.Transparent
        Me.LbBatteryPi.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBatteryPi.ForeColor = System.Drawing.Color.Transparent
        Me.LbBatteryPi.Location = New System.Drawing.Point(1009, 18)
        Me.LbBatteryPi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbBatteryPi.Name = "LbBatteryPi"
        Me.LbBatteryPi.Size = New System.Drawing.Size(29, 35)
        Me.LbBatteryPi.TabIndex = 71
        Me.LbBatteryPi.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(872, 18)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 35)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "BatteryPI:"
        '
        'LbBatG
        '
        Me.LbBatG.AutoSize = True
        Me.LbBatG.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.LbBatG.Location = New System.Drawing.Point(1387, 47)
        Me.LbBatG.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbBatG.Name = "LbBatG"
        Me.LbBatG.Size = New System.Drawing.Size(29, 35)
        Me.LbBatG.TabIndex = 69
        Me.LbBatG.Text = "0"
        '
        'Lbmax
        '
        Me.Lbmax.AutoSize = True
        Me.Lbmax.BackColor = System.Drawing.Color.Transparent
        Me.Lbmax.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbmax.ForeColor = System.Drawing.Color.Transparent
        Me.Lbmax.Location = New System.Drawing.Point(536, 66)
        Me.Lbmax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbmax.Name = "Lbmax"
        Me.Lbmax.Size = New System.Drawing.Size(29, 35)
        Me.Lbmax.TabIndex = 68
        Me.Lbmax.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(449, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 35)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "GEAR:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(369, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 35)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "MAX SPEED:"
        '
        'LbGear
        '
        Me.LbGear.AutoSize = True
        Me.LbGear.BackColor = System.Drawing.Color.Transparent
        Me.LbGear.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbGear.ForeColor = System.Drawing.Color.Transparent
        Me.LbGear.Location = New System.Drawing.Point(145, 713)
        Me.LbGear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbGear.Name = "LbGear"
        Me.LbGear.Size = New System.Drawing.Size(29, 35)
        Me.LbGear.TabIndex = 67
        Me.LbGear.Text = "0"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LbCranks)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.TargetPWR)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.LbDist)
        Me.Panel3.Controls.Add(Me.LbSpeed2)
        Me.Panel3.Controls.Add(Me.LbSpeed)
        Me.Panel3.Controls.Add(Me.LbPower)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Chart2)
        Me.Panel3.Controls.Add(Me.GroupBox5)
        Me.Panel3.Controls.Add(Me.GroupBox4)
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.LbGear)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Chart1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 121)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1523, 797)
        Me.Panel3.TabIndex = 66
        '
        'LbCranks
        '
        Me.LbCranks.AutoSize = True
        Me.LbCranks.BackColor = System.Drawing.Color.Transparent
        Me.LbCranks.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCranks.ForeColor = System.Drawing.Color.Transparent
        Me.LbCranks.Location = New System.Drawing.Point(764, 43)
        Me.LbCranks.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbCranks.Name = "LbCranks"
        Me.LbCranks.Size = New System.Drawing.Size(29, 35)
        Me.LbCranks.TabIndex = 82
        Me.LbCranks.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(648, 43)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 35)
        Me.Label13.TabIndex = 81
        Me.Label13.Text = "Cadence:"
        '
        'TargetPWR
        '
        Me.TargetPWR.AutoSize = True
        Me.TargetPWR.BackColor = System.Drawing.Color.Transparent
        Me.TargetPWR.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TargetPWR.ForeColor = System.Drawing.Color.Transparent
        Me.TargetPWR.Location = New System.Drawing.Point(733, 713)
        Me.TargetPWR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TargetPWR.Name = "TargetPWR"
        Me.TargetPWR.Size = New System.Drawing.Size(29, 35)
        Me.TargetPWR.TabIndex = 80
        Me.TargetPWR.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(536, 713)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(177, 35)
        Me.Label12.TabIndex = 79
        Me.Label12.Text = "Target Power:"
        '
        'LbDist
        '
        Me.LbDist.AutoSize = True
        Me.LbDist.BackColor = System.Drawing.Color.Transparent
        Me.LbDist.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDist.ForeColor = System.Drawing.Color.Transparent
        Me.LbDist.Location = New System.Drawing.Point(289, 713)
        Me.LbDist.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbDist.Name = "LbDist"
        Me.LbDist.Size = New System.Drawing.Size(29, 35)
        Me.LbDist.TabIndex = 75
        Me.LbDist.Text = "0"
        '
        'LbSpeed2
        '
        Me.LbSpeed2.AutoSize = True
        Me.LbSpeed2.BackColor = System.Drawing.Color.Transparent
        Me.LbSpeed2.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSpeed2.ForeColor = System.Drawing.Color.Transparent
        Me.LbSpeed2.Location = New System.Drawing.Point(396, 43)
        Me.LbSpeed2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbSpeed2.Name = "LbSpeed2"
        Me.LbSpeed2.Size = New System.Drawing.Size(29, 35)
        Me.LbSpeed2.TabIndex = 78
        Me.LbSpeed2.Text = "0"
        '
        'LbSpeed
        '
        Me.LbSpeed.AutoSize = True
        Me.LbSpeed.BackColor = System.Drawing.Color.Transparent
        Me.LbSpeed.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSpeed.ForeColor = System.Drawing.Color.Transparent
        Me.LbSpeed.Location = New System.Drawing.Point(301, 43)
        Me.LbSpeed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbSpeed.Name = "LbSpeed"
        Me.LbSpeed.Size = New System.Drawing.Size(95, 35)
        Me.LbSpeed.TabIndex = 77
        Me.LbSpeed.Text = "SPEED:"
        '
        'LbPower
        '
        Me.LbPower.AutoSize = True
        Me.LbPower.BackColor = System.Drawing.Color.Transparent
        Me.LbPower.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPower.ForeColor = System.Drawing.Color.Transparent
        Me.LbPower.Location = New System.Drawing.Point(1197, 43)
        Me.LbPower.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbPower.Name = "LbPower"
        Me.LbPower.Size = New System.Drawing.Size(29, 35)
        Me.LbPower.TabIndex = 76
        Me.LbPower.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(1080, 43)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 35)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "POWER:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(33, 713)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 35)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Distance to Finish:"
        '
        'Chart2
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend1)
        Me.Chart2.Location = New System.Drawing.Point(771, 92)
        Me.Chart2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Chart2.Name = "Chart2"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart2.Series.Add(Series1)
        Me.Chart2.Size = New System.Drawing.Size(735, 418)
        Me.Chart2.TabIndex = 67
        Me.Chart2.Text = "Chart2"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.LbChain)
        Me.GroupBox5.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(1239, 542)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(267, 123)
        Me.GroupBox5.TabIndex = 63
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "CHAINS"
        '
        'LbChain
        '
        Me.LbChain.AutoSize = True
        Me.LbChain.Font = New System.Drawing.Font("Nirmala UI", 11.25!)
        Me.LbChain.ForeColor = System.Drawing.Color.Black
        Me.LbChain.Location = New System.Drawing.Point(8, 53)
        Me.LbChain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbChain.Name = "LbChain"
        Me.LbChain.Size = New System.Drawing.Size(109, 25)
        Me.LbChain.TabIndex = 4
        Me.LbChain.Text = "STATUS: OK"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(931, 542)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(267, 123)
        Me.GroupBox4.TabIndex = 64
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GEAR"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 11.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(8, 53)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 25)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "STATUS: OK"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(632, 542)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(267, 123)
        Me.GroupBox3.TabIndex = 65
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RPM RIGHT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 53)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 25)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "STATUS: OK"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(336, 542)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(267, 123)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RPM LEFT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 11.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 53)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "STATUS: OK"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(28, 542)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(267, 123)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RPM CENTRE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 11.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 53)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "STATUS: OK"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(839, 238)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(609, 22)
        Me.TextBox1.TabIndex = 58
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(28, 92)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(735, 418)
        Me.Chart1.TabIndex = 59
        Me.Chart1.Text = "Chart1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1836, 918)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "MQ SPEED TELEMETRY"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents LbSenRPML As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LbSenRPMC As Label
    Friend WithEvents LbSenRPMR As Label
    Friend WithEvents lbENVSen As Label
    Friend WithEvents lbSenShaft As Label
    Friend WithEvents LbSenCrank As Label
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
    Friend WithEvents LbGear As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LbGear2 As Label
    Friend WithEvents LbPower As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LbSpeed2 As Label
    Friend WithEvents LbSpeed As Label
    Friend WithEvents LbDist As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TargetPWR As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LbCranks As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnSettings As Button
End Class
