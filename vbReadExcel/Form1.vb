Imports System.IO
Imports ExcelDataReader

Public Class Form1
    Dim tables As DataTableCollection
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub buttonBrowseFile_1_Click(sender As Object, e As EventArgs) Handles buttonBrowseFile_1.Click, Button1.Click
        openFileExcelDialog(textBoxFileName_1, comboBoxSheet_1)
    End Sub

    Private Sub comboBoxSheet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxSheet_1.SelectedIndexChanged
        Dim dataTable = tables(comboBoxSheet_1.SelectedItem.ToString)
        Dim checkBoxDGV As New DataGridViewCheckBoxColumn
        Dim checkBoxHeaderDGV As New DataGridViewColumnHeaderCell

        DataGridView_1.DataSource = dataTable
        checkBoxDGV.HeaderCell = checkBoxHeaderDGV
        checkBoxDGV.Width = 40
        checkBoxDGV.Name = "checkBoxDataGridView"
        checkBoxDGV.HeaderText = ""
        DataGridView_1.Columns.Insert(0, checkBoxDGV)
    End Sub

    Private Sub buttonBrowseFile_2_Click(sender As Object, e As EventArgs) Handles buttonBrowseFile_2.Click
        openFileExcelDialog(textBoxFileName_2, comboBoxSheet_2)
    End Sub

    Public Sub openFileExcelDialog(textBoxOpenDialog As TextBox, comboBoxOpenDialog As ComboBox)
        Using openFileDialog As OpenFileDialog = New OpenFileDialog With {.Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls"}
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                textBoxOpenDialog.Text = openFileDialog.FileName
                Using streamFile = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read)
                    Using readerFile As IExcelDataReader = ExcelReaderFactory.CreateReader(streamFile)
                        Dim result As DataSet = readerFile.AsDataSet(New ExcelDataSetConfiguration() With {
                                                                     .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {
                                                                     .UseHeaderRow = True}})
                        tables = result.Tables
                        comboBoxOpenDialog.Items.Clear()
                        For Each table As DataTable In tables
                            comboBoxOpenDialog.Items.Add(table.TableName)
                        Next
                    End Using
                End Using
            End If
        End Using
    End Sub

    Private Sub comboBoxSheet_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxSheet_2.SelectedIndexChanged
        Dim dataTable = tables(comboBoxSheet_2.SelectedItem.ToString)
        DataGridView_2.DataSource = dataTable
    End Sub

    Private Sub textBoxFileName_1_TextChanged(sender As Object, e As EventArgs) Handles textBoxFileName_1.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub buttonGetText_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
End Class
