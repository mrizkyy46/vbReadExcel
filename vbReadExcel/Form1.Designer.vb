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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textBoxFileName_1 = New System.Windows.Forms.TextBox()
        Me.buttonBrowseFile_1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comboBoxSheet_1 = New System.Windows.Forms.ComboBox()
        Me.comboBoxSheet_2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.buttonBrowseFile_2 = New System.Windows.Forms.Button()
        Me.textBoxFileName_2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView_2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView_1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.buttonCompare = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.buttonExportToExcel = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 249)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&File Name"
        '
        'textBoxFileName_1
        '
        Me.textBoxFileName_1.Location = New System.Drawing.Point(89, 249)
        Me.textBoxFileName_1.Name = "textBoxFileName_1"
        Me.textBoxFileName_1.Size = New System.Drawing.Size(370, 20)
        Me.textBoxFileName_1.TabIndex = 2
        '
        'buttonBrowseFile_1
        '
        Me.buttonBrowseFile_1.Location = New System.Drawing.Point(465, 249)
        Me.buttonBrowseFile_1.Name = "buttonBrowseFile_1"
        Me.buttonBrowseFile_1.Size = New System.Drawing.Size(32, 20)
        Me.buttonBrowseFile_1.TabIndex = 3
        Me.buttonBrowseFile_1.Text = ". . ."
        Me.buttonBrowseFile_1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 275)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "&Sheet"
        '
        'comboBoxSheet_1
        '
        Me.comboBoxSheet_1.FormattingEnabled = True
        Me.comboBoxSheet_1.Location = New System.Drawing.Point(89, 275)
        Me.comboBoxSheet_1.Name = "comboBoxSheet_1"
        Me.comboBoxSheet_1.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxSheet_1.TabIndex = 5
        '
        'comboBoxSheet_2
        '
        Me.comboBoxSheet_2.FormattingEnabled = True
        Me.comboBoxSheet_2.Location = New System.Drawing.Point(89, 563)
        Me.comboBoxSheet_2.Name = "comboBoxSheet_2"
        Me.comboBoxSheet_2.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxSheet_2.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 563)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "&Sheet"
        '
        'buttonBrowseFile_2
        '
        Me.buttonBrowseFile_2.Location = New System.Drawing.Point(465, 537)
        Me.buttonBrowseFile_2.Name = "buttonBrowseFile_2"
        Me.buttonBrowseFile_2.Size = New System.Drawing.Size(32, 20)
        Me.buttonBrowseFile_2.TabIndex = 9
        Me.buttonBrowseFile_2.Text = ". . ."
        Me.buttonBrowseFile_2.UseVisualStyleBackColor = True
        '
        'textBoxFileName_2
        '
        Me.textBoxFileName_2.Location = New System.Drawing.Point(89, 537)
        Me.textBoxFileName_2.Name = "textBoxFileName_2"
        Me.textBoxFileName_2.Size = New System.Drawing.Size(370, 20)
        Me.textBoxFileName_2.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 538)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "&File Name"
        '
        'DataGridView_2
        '
        Me.DataGridView_2.AllowUserToOrderColumns = True
        Me.DataGridView_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_2.Location = New System.Drawing.Point(12, 302)
        Me.DataGridView_2.Name = "DataGridView_2"
        Me.DataGridView_2.Size = New System.Drawing.Size(1162, 233)
        Me.DataGridView_2.TabIndex = 6
        '
        'DataGridView_1
        '
        Me.DataGridView_1.AllowUserToOrderColumns = True
        Me.DataGridView_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView_1.Name = "DataGridView_1"
        Me.DataGridView_1.Size = New System.Drawing.Size(1161, 233)
        Me.DataGridView_1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(465, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 20)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = ". . ."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'buttonCompare
        '
        Me.buttonCompare.Location = New System.Drawing.Point(293, 275)
        Me.buttonCompare.Name = "buttonCompare"
        Me.buttonCompare.Size = New System.Drawing.Size(204, 21)
        Me.buttonCompare.TabIndex = 12
        Me.buttonCompare.Text = "&Compare && Replace"
        Me.buttonCompare.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(15, 602)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(286, 115)
        Me.RichTextBox1.TabIndex = 13
        Me.RichTextBox1.Text = "1. Import raw.xlsx pada table 1" & Global.Microsoft.VisualBasic.ChrW(10) & "2. Import template.xlsx pada table 2" & Global.Microsoft.VisualBasic.ChrW(10) & "3. Select da" &
    "ta range di table raw" & Global.Microsoft.VisualBasic.ChrW(10) & "4. Klik Compare & Replace" & Global.Microsoft.VisualBasic.ChrW(10) & "5. Export data table ke excel"
        '
        'buttonExportToExcel
        '
        Me.buttonExportToExcel.Location = New System.Drawing.Point(216, 563)
        Me.buttonExportToExcel.Name = "buttonExportToExcel"
        Me.buttonExportToExcel.Size = New System.Drawing.Size(281, 21)
        Me.buttonExportToExcel.TabIndex = 14
        Me.buttonExportToExcel.Text = "&Export to Excel"
        Me.buttonExportToExcel.UseVisualStyleBackColor = True
        Me.buttonExportToExcel.UseWaitCursor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(216, 277)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(71, 17)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Check All"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1186, 729)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.buttonExportToExcel)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.buttonCompare)
        Me.Controls.Add(Me.comboBoxSheet_2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.buttonBrowseFile_2)
        Me.Controls.Add(Me.textBoxFileName_2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView_2)
        Me.Controls.Add(Me.comboBoxSheet_1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.buttonBrowseFile_1)
        Me.Controls.Add(Me.textBoxFileName_1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView_1)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Read Excel File (.xls, .xlsx)"
        CType(Me.DataGridView_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents textBoxFileName_1 As TextBox
    Friend WithEvents buttonBrowseFile_1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents comboBoxSheet_1 As ComboBox
    Friend WithEvents comboBoxSheet_2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents buttonBrowseFile_2 As Button
    Friend WithEvents textBoxFileName_2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView_2 As DataGridView
    Friend WithEvents DataGridView_1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents buttonCompare As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents buttonExportToExcel As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
