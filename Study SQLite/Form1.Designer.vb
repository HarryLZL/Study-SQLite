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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button_CreateTable = New System.Windows.Forms.Button()
        Me.Panel_Title = New System.Windows.Forms.Panel()
        Me.Button_Quit = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button_Insert = New System.Windows.Forms.Button()
        Me.Button_Serarch = New System.Windows.Forms.Button()
        Me.DataGridView_Search = New System.Windows.Forms.DataGridView()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_UserName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_Password = New System.Windows.Forms.TextBox()
        Me.Panel_Title.SuspendLayout()
        CType(Me.DataGridView_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_CreateTable
        '
        Me.Button_CreateTable.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button_CreateTable.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.Button_CreateTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_CreateTable.ForeColor = System.Drawing.Color.White
        Me.Button_CreateTable.Location = New System.Drawing.Point(3, 23)
        Me.Button_CreateTable.Name = "Button_CreateTable"
        Me.Button_CreateTable.Size = New System.Drawing.Size(112, 38)
        Me.Button_CreateTable.TabIndex = 0
        Me.Button_CreateTable.Text = "Create Table"
        Me.Button_CreateTable.UseVisualStyleBackColor = False
        '
        'Panel_Title
        '
        Me.Panel_Title.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel_Title.Controls.Add(Me.Button_Quit)
        Me.Panel_Title.Controls.Add(Me.Button4)
        Me.Panel_Title.Controls.Add(Me.Button3)
        Me.Panel_Title.Controls.Add(Me.Button_Insert)
        Me.Panel_Title.Controls.Add(Me.Button_Serarch)
        Me.Panel_Title.Controls.Add(Me.Button_CreateTable)
        Me.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Title.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Title.Name = "Panel_Title"
        Me.Panel_Title.Size = New System.Drawing.Size(607, 65)
        Me.Panel_Title.TabIndex = 1
        '
        'Button_Quit
        '
        Me.Button_Quit.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button_Quit.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.Button_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Quit.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Button_Quit.Location = New System.Drawing.Point(561, 22)
        Me.Button_Quit.Name = "Button_Quit"
        Me.Button_Quit.Size = New System.Drawing.Size(43, 40)
        Me.Button_Quit.TabIndex = 5
        Me.Button_Quit.Text = "Quit"
        Me.Button_Quit.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(451, 23)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 38)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(339, 23)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 38)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Modify"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button_Insert
        '
        Me.Button_Insert.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button_Insert.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.Button_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Insert.ForeColor = System.Drawing.Color.White
        Me.Button_Insert.Location = New System.Drawing.Point(227, 23)
        Me.Button_Insert.Name = "Button_Insert"
        Me.Button_Insert.Size = New System.Drawing.Size(112, 38)
        Me.Button_Insert.TabIndex = 2
        Me.Button_Insert.Text = "Insert"
        Me.Button_Insert.UseVisualStyleBackColor = False
        '
        'Button_Serarch
        '
        Me.Button_Serarch.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button_Serarch.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.Button_Serarch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Serarch.ForeColor = System.Drawing.Color.White
        Me.Button_Serarch.Location = New System.Drawing.Point(115, 23)
        Me.Button_Serarch.Name = "Button_Serarch"
        Me.Button_Serarch.Size = New System.Drawing.Size(112, 38)
        Me.Button_Serarch.TabIndex = 1
        Me.Button_Serarch.Text = "Search"
        Me.Button_Serarch.UseVisualStyleBackColor = False
        '
        'DataGridView_Search
        '
        Me.DataGridView_Search.AllowUserToAddRows = False
        Me.DataGridView_Search.AllowUserToDeleteRows = False
        Me.DataGridView_Search.AllowUserToOrderColumns = True
        Me.DataGridView_Search.AllowUserToResizeColumns = False
        Me.DataGridView_Search.AllowUserToResizeRows = False
        Me.DataGridView_Search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_Search.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView_Search.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Search.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_Search.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_Search.Location = New System.Drawing.Point(0, 92)
        Me.DataGridView_Search.MultiSelect = False
        Me.DataGridView_Search.Name = "DataGridView_Search"
        Me.DataGridView_Search.ReadOnly = True
        Me.DataGridView_Search.RowHeadersVisible = False
        Me.DataGridView_Search.RowTemplate.Height = 30
        Me.DataGridView_Search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Search.Size = New System.Drawing.Size(607, 250)
        Me.DataGridView_Search.TabIndex = 6
        '
        'TextBox_ID
        '
        Me.TextBox_ID.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_ID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_ID.Location = New System.Drawing.Point(49, 73)
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.ReadOnly = True
        Me.TextBox_ID.Size = New System.Drawing.Size(100, 16)
        Me.TextBox_ID.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(155, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "UserName :"
        '
        'TextBox_UserName
        '
        Me.TextBox_UserName.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBox_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_UserName.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox_UserName.Location = New System.Drawing.Point(238, 69)
        Me.TextBox_UserName.Name = "TextBox_UserName"
        Me.TextBox_UserName.Size = New System.Drawing.Size(100, 18)
        Me.TextBox_UserName.TabIndex = 9
        Me.TextBox_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(344, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Password :"
        '
        'TextBox_Password
        '
        Me.TextBox_Password.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Password.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox_Password.Location = New System.Drawing.Point(421, 69)
        Me.TextBox_Password.Name = "TextBox_Password"
        Me.TextBox_Password.Size = New System.Drawing.Size(100, 18)
        Me.TextBox_Password.TabIndex = 11
        Me.TextBox_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(607, 342)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_Password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_UserName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_ID)
        Me.Controls.Add(Me.DataGridView_Search)
        Me.Controls.Add(Me.Panel_Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TopMost = True
        Me.Panel_Title.ResumeLayout(False)
        CType(Me.DataGridView_Search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_CreateTable As Button
    Friend WithEvents Panel_Title As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button_Insert As Button
    Friend WithEvents Button_Serarch As Button
    Friend WithEvents Button_Quit As Button
    Friend WithEvents DataGridView_Search As DataGridView
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_UserName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_Password As TextBox
End Class
