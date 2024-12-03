<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.txtDistanceToFinish = New System.Windows.Forms.TextBox()
        Me.dgvPowerRanges = New System.Windows.Forms.DataGridView()
        Me.Range_Start = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Range_End = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Target_Power = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LbSpeed = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.dgvPowerRanges, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDistanceToFinish
        '
        Me.txtDistanceToFinish.BackColor = System.Drawing.Color.White
        Me.txtDistanceToFinish.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtDistanceToFinish.ForeColor = System.Drawing.Color.Black
        Me.txtDistanceToFinish.Location = New System.Drawing.Point(160, 27)
        Me.txtDistanceToFinish.Multiline = True
        Me.txtDistanceToFinish.Name = "txtDistanceToFinish"
        Me.txtDistanceToFinish.Size = New System.Drawing.Size(121, 34)
        Me.txtDistanceToFinish.TabIndex = 10
        '
        'dgvPowerRanges
        '
        Me.dgvPowerRanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPowerRanges.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Range_Start, Me.Range_End, Me.Target_Power})
        Me.dgvPowerRanges.Location = New System.Drawing.Point(12, 79)
        Me.dgvPowerRanges.Name = "dgvPowerRanges"
        Me.dgvPowerRanges.Size = New System.Drawing.Size(343, 150)
        Me.dgvPowerRanges.TabIndex = 11
        '
        'Range_Start
        '
        Me.Range_Start.HeaderText = "Range_Start"
        Me.Range_Start.Name = "Range_Start"
        '
        'Range_End
        '
        Me.Range_End.HeaderText = "Range_End"
        Me.Range_End.Name = "Range_End"
        '
        'Target_Power
        '
        Me.Target_Power.HeaderText = "Target_Power"
        Me.Target_Power.Name = "Target_Power"
        '
        'LbSpeed
        '
        Me.LbSpeed.AutoSize = True
        Me.LbSpeed.BackColor = System.Drawing.Color.Transparent
        Me.LbSpeed.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSpeed.ForeColor = System.Drawing.Color.Transparent
        Me.LbSpeed.Location = New System.Drawing.Point(12, 27)
        Me.LbSpeed.Name = "LbSpeed"
        Me.LbSpeed.Size = New System.Drawing.Size(152, 28)
        Me.LbSpeed.TabIndex = 78
        Me.LbSpeed.Text = "SET DISTANCE:"
        '
        'btnSave
        '
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Transparent
        Me.btnSave.Location = New System.Drawing.Point(17, 251)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(337, 32)
        Me.btnSave.TabIndex = 79
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(366, 311)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.LbSpeed)
        Me.Controls.Add(Me.dgvPowerRanges)
        Me.Controls.Add(Me.txtDistanceToFinish)
        Me.Name = "Form2"
        Me.Text = "Settings"
        CType(Me.dgvPowerRanges, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDistanceToFinish As TextBox
    Friend WithEvents dgvPowerRanges As DataGridView
    Friend WithEvents Range_Start As DataGridViewTextBoxColumn
    Friend WithEvents Range_End As DataGridViewTextBoxColumn
    Friend WithEvents Target_Power As DataGridViewTextBoxColumn
    Friend WithEvents LbSpeed As Label
    Friend WithEvents btnSave As Button
End Class
