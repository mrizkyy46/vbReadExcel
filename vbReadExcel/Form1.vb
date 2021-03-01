Imports System.IO
Imports ExcelDataReader

Public Class Form1
    Dim tables As DataTableCollection
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub buttonBrowseFile_1_Click(sender As Object, e As EventArgs) Handles buttonBrowseFile_1.Click
        'Using openFileDialog As OpenFileDialog = New OpenFileDialog With {.Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls"}
        '    If openFileDialog.ShowDialog() = DialogResult.OK Then
        '        textBoxFileName_1.Text = openFileDialog.FileName
        '        Using streamFile = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read)
        '            Using readerFile As IExcelDataReader = ExcelReaderFactory.CreateReader(streamFile)
        '                Dim result As DataSet = readerFile.AsDataSet(New ExcelDataSetConfiguration() With {
        '                                                             .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {
        '                                                             .UseHeaderRow = True}})
        '                tables = result.Tables
        '                comboBoxSheet_1.Items.Clear()
        '                For Each table As DataTable In tables
        '                    comboBoxSheet_1.Items.Add(table.TableName)
        '                Next
        '            End Using
        '        End Using
        '    End If
        'End Using
        openFileExcelDialog(textBoxFileName_1, comboBoxSheet_1)
    End Sub

    Private Sub comboBoxSheet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxSheet_1.SelectedIndexChanged
        Dim dataTable = tables(comboBoxSheet_1.SelectedItem.ToString)
        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub buttonBrowseFile_2_Click(sender As Object, e As EventArgs) Handles buttonBrowseFile_2.Click
        openFileExcelDialog(textBoxFileName_2, comboBoxSheet_2)
    End Sub

    Public Sub openFileExcelDialog(textBox As TextBox, comboBox As ComboBox)
        Using openFileDialog As OpenFileDialog = New OpenFileDialog With {.Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls"}
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                textBox.Text = openFileDialog.FileName
                Using streamFile = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read)
                    Using readerFile As IExcelDataReader = ExcelReaderFactory.CreateReader(streamFile)
                        Dim result As DataSet = readerFile.AsDataSet(New ExcelDataSetConfiguration() With {
                                                                     .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {
                                                                     .UseHeaderRow = True}})
                        tables = result.Tables
                        comboBox.Items.Clear()
                        For Each table As DataTable In tables
                            comboBox.Items.Add(table.TableName)
                        Next
                    End Using
                End Using
            End If
        End Using
    End Sub

    Private Sub comboBoxSheet_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxSheet_2.SelectedIndexChanged
        Dim dataTable = tables(comboBoxSheet_2.SelectedItem.ToString)
        DataGridView2.DataSource = dataTable
    End Sub

    Private Sub textBoxFileName_1_TextChanged(sender As Object, e As EventArgs) Handles textBoxFileName_1.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
