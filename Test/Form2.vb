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
Public Class Form2
    ' Add this function to handle the button click event for loading CSV
    Private Sub btnLoadCSV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadCSV.Click
        ' Create a new OpenFileDialog
        Dim openFileDialog As New OpenFileDialog()

        ' Set filter options and filter index
        openFileDialog.Filter = "CSV Files|*.csv|All Files|*.*"
        openFileDialog.FilterIndex = 1
        openFileDialog.Multiselect = False

        ' Call the ShowDialog method to show the dialog box
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Read the selected file
            Dim filePath As String = openFileDialog.FileName
            Dim csvData As List(Of String()) = ReadCSVFile(filePath)

            ' Plot the data
            PlotCSVData(csvData)
        End If
    End Sub

    ' Function to read the CSV file
    Private Function ReadCSVFile(ByVal filePath As String) As List(Of String())
        Dim csvData As New List(Of String())

        Try
            Using reader As New StreamReader(filePath)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim values As String() = line.Split(","c)
                    csvData.Add(values)
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error reading CSV file: " & ex.Message)
        End Try

        Return csvData
    End Function

    ' Function to plot CSV data on the chart
    Private Sub PlotCSVData(ByVal csvData As List(Of String()))
        ' Clear the existing data
        Chart1.Series("Humidity").Points.Clear()
        Chart2.Series("Temperature").Points.Clear()

        ' Loop through the CSV data and add points to the chart
        For Each row As String() In csvData
            If row.Length >= 3 Then ' Ensure there are at least three columns
                Try
                    Dim RPM_C As Decimal = Convert.ToDecimal(row(1)) ' Second column for humidity
                    Dim value2 As Decimal = Convert.ToDecimal(row(2)) ' Third column for temperature

                    Chart1.Series("Humidity").Points.AddY(RPM_C)
                    Chart2.Series("Temperature").Points.AddY(value2)
                Catch ex As FormatException
                    MessageBox.Show("Error parsing CSV data: " & ex.Message & " (Row: " & String.Join(",", row) & ")", "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As Exception
                    MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Invalid data format in row: " & String.Join(",", row), "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Next

        ' Adjust Y-axis maximum value dynamically if necessary
        'AdjustYAxisMaximum()
    End Sub

    ' Function to adjust Y-axis maximum value
    Private Sub AdjustYAxisMaximum()
        Dim maxValue As Decimal = 0

        For Each point As DataVisualization.Charting.DataPoint In Chart1.Series("Humidity").Points
            If point.YValues(0) > maxValue Then
                maxValue = point.YValues(0)
            End If
        Next

        For Each point As DataVisualization.Charting.DataPoint In Chart1.Series("Temperature").Points
            If point.YValues(0) > maxValue Then
                maxValue = point.YValues(0)
            End If
        Next

        Chart1.ChartAreas(0).AxisY.Maximum = maxValue
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class