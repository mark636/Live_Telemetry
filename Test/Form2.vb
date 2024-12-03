Public Class Form2
    ' Define properties to store and retrieve settings
    Public Property DistanceToFinish As Decimal
    Public Property TargetPowerRanges As New List(Of (Decimal, Decimal, Integer))

    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load Distance to Finish
        txtDistanceToFinish.Text = DistanceToFinish.ToString()

        ' Initialize the DataGridView
        SetupDataGridView()

        ' Populate the DataGridView with existing ranges
        For Each range In TargetPowerRanges
            dgvPowerRanges.Rows.Add(range.Item1, range.Item2, range.Item3)
        Next
    End Sub

    Private Sub SetupDataGridView()
        ' Clear existing setup
        dgvPowerRanges.Columns.Clear()

        ' Add Range Start column
        Dim colRangeStart As New DataGridViewTextBoxColumn()
        colRangeStart.Name = "RangeStart"
        colRangeStart.HeaderText = "Range Start"
        colRangeStart.ValueType = GetType(Decimal)
        dgvPowerRanges.Columns.Add(colRangeStart)

        ' Add Range End column
        Dim colRangeEnd As New DataGridViewTextBoxColumn()
        colRangeEnd.Name = "RangeEnd"
        colRangeEnd.HeaderText = "Range End"
        colRangeEnd.ValueType = GetType(Decimal)
        dgvPowerRanges.Columns.Add(colRangeEnd)

        ' Add Target Power column
        Dim colTargetPower As New DataGridViewTextBoxColumn()
        colTargetPower.Name = "TargetPower"
        colTargetPower.HeaderText = "Target Power (W)"
        colTargetPower.ValueType = GetType(Integer)
        dgvPowerRanges.Columns.Add(colTargetPower)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            ' Validate and save Distance to Finish
            If Not Decimal.TryParse(txtDistanceToFinish.Text, DistanceToFinish) Then
                MessageBox.Show("Invalid Distance to Finish value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Validate and save Power Ranges
            TargetPowerRanges.Clear()
            For Each row As DataGridViewRow In dgvPowerRanges.Rows
                If row.IsNewRow Then Continue For ' Skip the new row placeholder

                ' Validate inputs
                Dim rangeStart As Decimal
                Dim rangeEnd As Decimal
                Dim targetPower As Integer

                If Not Decimal.TryParse(row.Cells("RangeStart").Value?.ToString(), rangeStart) OrElse
                   Not Decimal.TryParse(row.Cells("RangeEnd").Value?.ToString(), rangeEnd) OrElse
                   Not Integer.TryParse(row.Cells("TargetPower").Value?.ToString(), targetPower) Then
                    MessageBox.Show("Invalid input in power ranges.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                If rangeStart >= rangeEnd Then
                    MessageBox.Show("Range Start must be less than Range End.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Add to list
                TargetPowerRanges.Add((rangeStart, rangeEnd, targetPower))
            Next

            ' Save successful
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show($"Error saving settings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
