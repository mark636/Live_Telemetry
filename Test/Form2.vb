Public Class Form2
    ' Define properties to store and retrieve settings
    Public Property DistanceToFinish As Decimal
    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load Distance to Finish
        txtDistanceToFinish.Text = DistanceToFinish.ToString()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            ' Validate and save Distance to Finish
            If Not Decimal.TryParse(txtDistanceToFinish.Text, DistanceToFinish) Then
                MessageBox.Show("Invalid Distance to Finish value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            ' Save successful
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show($"Error saving settings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
