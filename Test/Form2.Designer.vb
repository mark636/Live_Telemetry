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
        Me.LbSpeed = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDistanceToFinish
        '
        Me.txtDistanceToFinish.BackColor = System.Drawing.Color.White
        Me.txtDistanceToFinish.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtDistanceToFinish.ForeColor = System.Drawing.Color.Black
        Me.txtDistanceToFinish.Location = New System.Drawing.Point(213, 33)
        Me.txtDistanceToFinish.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDistanceToFinish.Multiline = True
        Me.txtDistanceToFinish.Name = "txtDistanceToFinish"
        Me.txtDistanceToFinish.Size = New System.Drawing.Size(160, 41)
        Me.txtDistanceToFinish.TabIndex = 10
        '
        'LbSpeed
        '
        Me.LbSpeed.AutoSize = True
        Me.LbSpeed.BackColor = System.Drawing.Color.Transparent
        Me.LbSpeed.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSpeed.ForeColor = System.Drawing.Color.Transparent
        Me.LbSpeed.Location = New System.Drawing.Point(16, 33)
        Me.LbSpeed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbSpeed.Name = "LbSpeed"
        Me.LbSpeed.Size = New System.Drawing.Size(191, 35)
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
        Me.btnSave.Location = New System.Drawing.Point(22, 113)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(449, 39)
        Me.btnSave.TabIndex = 79
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(488, 176)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.LbSpeed)
        Me.Controls.Add(Me.txtDistanceToFinish)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form2"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDistanceToFinish As TextBox
    Friend WithEvents LbSpeed As Label
    Friend WithEvents btnSave As Button
End Class
