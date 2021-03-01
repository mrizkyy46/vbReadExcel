<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 478)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&File Name"
        '
        'textBoxFileName_1
        '
        Me.textBoxFileName_1.Location = New System.Drawing.Point(87, 478)
        Me.textBoxFileName_1.Name = "textBoxFileName_1"
        Me.textBoxFileName_1.Size = New System.Drawing.Size(370, 20)
        Me.textBoxFileName_1.TabIndex = 2
        '
        'buttonBrowseFile_1
        '
        Me.buttonBrowseFile_1.Location = New System.Drawing.Point(463, 478)
        Me.buttonBrowseFile_1.Name = "buttonBrowseFile_1"
        Me.buttonBrowseFile_1.Size = New System.Drawing.Size(32, 20)
        Me.buttonBrowseFile_1.TabIndex = 3
        Me.buttonBrowseFile_1.Text = ". . ."
        Me.buttonBrowseFile_1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 522)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "&Sheet"
        '
        'comboBoxSheet_1
        '
        Me.comboBoxSheet_1.FormattingEnabled = True
        Me.comboBoxSheet_1.Location = New System.Drawing.Point(87, 522)
        Me.comboBoxSheet_1.Name = "comboBoxSheet_1"
        Me.comboBoxSheet_1.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxSheet_1.TabIndex = 5
        '
        'comboBoxSheet_2
        '
        Me.comboBoxSheet_2.FormattingEnabled = True
        Me.comboBoxSheet_2.Location = New System.Drawing.Point(571, 522)
        Me.comboBoxSheet_2.Name = "comboBoxSheet_2"
        Me.comboBoxSheet_2.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxSheet_2.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(511, 522)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "&Sheet"
        '
        'buttonBrowseFile_2
        '
        Me.buttonBrowseFile_2.Location = New System.Drawing.Point(964, 475)
        Me.buttonBrowseFile_2.Name = "buttonBrowseFile_2"
        Me.buttonBrowseFile_2.Size = New System.Drawing.Size(32, 20)
        Me.buttonBrowseFile_2.TabIndex = 9
        Me.buttonBrowseFile_2.Text = ". . ."
        Me.buttonBrowseFile_2.UseVisualStyleBackColor = True
        '
        'textBoxFileName_2
        '
        Me.textBoxFileName_2.Location = New System.Drawing.Point(571, 475)
        Me.textBoxFileName_2.Name = "textBoxFileName_2"
        Me.textBoxFileName_2.Size = New System.Drawing.Size(387, 20)
        Me.textBoxFileName_2.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(511, 476)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "&File Name"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(514, 12)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(482, 450)
        Me.DataGridView2.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(482, 450)
        Me.DataGridView1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.comboBoxSheet_2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.buttonBrowseFile_2)
        Me.Controls.Add(Me.textBoxFileName_2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.comboBoxSheet_1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.buttonBrowseFile_1)
        Me.Controls.Add(Me.textBoxFileName_1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Read Excel File (.xls, .xlsx)"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
End Class
