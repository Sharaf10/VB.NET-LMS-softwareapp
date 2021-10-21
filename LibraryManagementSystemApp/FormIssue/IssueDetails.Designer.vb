<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IssueDetails
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnreset = New Guna.UI2.WinForms.Guna2Button()
        Me.btndelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnedit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnsave = New Guna.UI2.WinForms.Guna2Button()
        Me.txtaddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtstock = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtcontact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbooks = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtsearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BorderRadius = 15
        Me.Guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2Button1.HoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(901, 290)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(151, 37)
        Me.Guna2Button1.TabIndex = 74
        Me.Guna2Button1.Text = "Print report"
        '
        'Guna2DataGridView1
        '
        Me.Guna2DataGridView1.AllowUserToAddRows = False
        Me.Guna2DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.Guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Guna2DataGridView1.BackgroundColor = System.Drawing.Color.LightGray
        Me.Guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.Guna2DataGridView1.ColumnHeadersHeight = 29
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle12
        Me.Guna2DataGridView1.EnableHeadersVisualStyles = False
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(22, 394)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.ReadOnly = True
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.RowHeadersWidth = 51
        Me.Guna2DataGridView1.RowTemplate.Height = 24
        Me.Guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Guna2DataGridView1.ShowEditingIcon = False
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(1207, 379)
        Me.Guna2DataGridView1.TabIndex = 73
        Me.Guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.LightGray
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 29
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = True
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnreset
        '
        Me.btnreset.Animated = True
        Me.btnreset.BorderRadius = 15
        Me.btnreset.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnreset.CheckedState.Parent = Me.btnreset
        Me.btnreset.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnreset.CustomImages.Parent = Me.btnreset
        Me.btnreset.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnreset.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.ForeColor = System.Drawing.Color.White
        Me.btnreset.HoverState.FillColor = System.Drawing.Color.CornflowerBlue
        Me.btnreset.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnreset.HoverState.Parent = Me.btnreset
        Me.btnreset.Location = New System.Drawing.Point(715, 290)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.ShadowDecoration.Parent = Me.btnreset
        Me.btnreset.Size = New System.Drawing.Size(118, 37)
        Me.btnreset.TabIndex = 72
        Me.btnreset.Text = "Reset"
        '
        'btndelete
        '
        Me.btndelete.Animated = True
        Me.btndelete.BorderRadius = 15
        Me.btndelete.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btndelete.CheckedState.Parent = Me.btndelete
        Me.btndelete.Cursor = System.Windows.Forms.Cursors.Default
        Me.btndelete.CustomImages.Parent = Me.btndelete
        Me.btndelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btndelete.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.HoverState.FillColor = System.Drawing.Color.CornflowerBlue
        Me.btndelete.HoverState.ForeColor = System.Drawing.Color.White
        Me.btndelete.HoverState.Parent = Me.btndelete
        Me.btndelete.Location = New System.Drawing.Point(530, 290)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.ShadowDecoration.Parent = Me.btndelete
        Me.btndelete.Size = New System.Drawing.Size(118, 37)
        Me.btndelete.TabIndex = 71
        Me.btndelete.Text = "Delete"
        '
        'btnedit
        '
        Me.btnedit.Animated = True
        Me.btnedit.BorderRadius = 15
        Me.btnedit.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnedit.CausesValidation = False
        Me.btnedit.CheckedState.Parent = Me.btnedit
        Me.btnedit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnedit.CustomImages.Parent = Me.btnedit
        Me.btnedit.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnedit.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.White
        Me.btnedit.HoverState.FillColor = System.Drawing.Color.CornflowerBlue
        Me.btnedit.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnedit.HoverState.Parent = Me.btnedit
        Me.btnedit.Location = New System.Drawing.Point(345, 290)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.ShadowDecoration.Parent = Me.btnedit
        Me.btnedit.Size = New System.Drawing.Size(118, 37)
        Me.btnedit.TabIndex = 70
        Me.btnedit.Text = "Edit"
        '
        'btnsave
        '
        Me.btnsave.Animated = True
        Me.btnsave.BorderRadius = 15
        Me.btnsave.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnsave.CheckedState.Parent = Me.btnsave
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnsave.CustomImages.Parent = Me.btnsave
        Me.btnsave.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.HoverState.FillColor = System.Drawing.Color.CornflowerBlue
        Me.btnsave.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnsave.HoverState.Parent = Me.btnsave
        Me.btnsave.Location = New System.Drawing.Point(160, 290)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.ShadowDecoration.Parent = Me.btnsave
        Me.btnsave.Size = New System.Drawing.Size(118, 37)
        Me.btnsave.TabIndex = 69
        Me.btnsave.Text = "Save"
        '
        'txtaddress
        '
        Me.txtaddress.Animated = True
        Me.txtaddress.BackColor = System.Drawing.Color.Transparent
        Me.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtaddress.DefaultText = ""
        Me.txtaddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtaddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtaddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtaddress.DisabledState.Parent = Me.txtaddress
        Me.txtaddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtaddress.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtaddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtaddress.FocusedState.Parent = Me.txtaddress
        Me.txtaddress.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtaddress.HoverState.Parent = Me.txtaddress
        Me.txtaddress.Location = New System.Drawing.Point(884, 194)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtaddress.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtaddress.PlaceholderText = "Address"
        Me.txtaddress.SelectedText = ""
        Me.txtaddress.ShadowDecoration.Parent = Me.txtaddress
        Me.txtaddress.Size = New System.Drawing.Size(235, 50)
        Me.txtaddress.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtaddress.TabIndex = 68
        '
        'txtstock
        '
        Me.txtstock.Animated = True
        Me.txtstock.BackColor = System.Drawing.Color.Transparent
        Me.txtstock.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtstock.DefaultText = ""
        Me.txtstock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtstock.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtstock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtstock.DisabledState.Parent = Me.txtstock
        Me.txtstock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtstock.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtstock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtstock.FocusedState.Parent = Me.txtstock
        Me.txtstock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstock.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtstock.HoverState.Parent = Me.txtstock
        Me.txtstock.Location = New System.Drawing.Point(748, 194)
        Me.txtstock.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtstock.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtstock.PlaceholderText = "Stock"
        Me.txtstock.SelectedText = ""
        Me.txtstock.ShadowDecoration.Parent = Me.txtstock
        Me.txtstock.Size = New System.Drawing.Size(99, 50)
        Me.txtstock.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtstock.TabIndex = 67
        '
        'txtcontact
        '
        Me.txtcontact.Animated = True
        Me.txtcontact.BackColor = System.Drawing.Color.Transparent
        Me.txtcontact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcontact.DefaultText = ""
        Me.txtcontact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcontact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcontact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcontact.DisabledState.Parent = Me.txtcontact
        Me.txtcontact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcontact.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtcontact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcontact.FocusedState.Parent = Me.txtcontact
        Me.txtcontact.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcontact.HoverState.Parent = Me.txtcontact
        Me.txtcontact.Location = New System.Drawing.Point(518, 194)
        Me.txtcontact.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcontact.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtcontact.PlaceholderText = "Contact"
        Me.txtcontact.SelectedText = ""
        Me.txtcontact.ShadowDecoration.Parent = Me.txtcontact
        Me.txtcontact.Size = New System.Drawing.Size(189, 50)
        Me.txtcontact.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtcontact.TabIndex = 66
        '
        'txtbooks
        '
        Me.txtbooks.Animated = True
        Me.txtbooks.BackColor = System.Drawing.Color.Transparent
        Me.txtbooks.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbooks.DefaultText = ""
        Me.txtbooks.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbooks.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbooks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbooks.DisabledState.Parent = Me.txtbooks
        Me.txtbooks.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbooks.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtbooks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbooks.FocusedState.Parent = Me.txtbooks
        Me.txtbooks.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbooks.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbooks.HoverState.Parent = Me.txtbooks
        Me.txtbooks.Location = New System.Drawing.Point(266, 194)
        Me.txtbooks.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtbooks.Name = "txtbooks"
        Me.txtbooks.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbooks.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtbooks.PlaceholderText = "Books"
        Me.txtbooks.SelectedText = ""
        Me.txtbooks.ShadowDecoration.Parent = Me.txtbooks
        Me.txtbooks.Size = New System.Drawing.Size(218, 50)
        Me.txtbooks.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtbooks.TabIndex = 65
        '
        'txtname
        '
        Me.txtname.Animated = True
        Me.txtname.BackColor = System.Drawing.Color.Transparent
        Me.txtname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtname.DefaultText = ""
        Me.txtname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtname.DisabledState.Parent = Me.txtname
        Me.txtname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtname.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtname.FocusedState.Parent = Me.txtname
        Me.txtname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtname.HoverState.Parent = Me.txtname
        Me.txtname.Location = New System.Drawing.Point(22, 194)
        Me.txtname.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtname.Name = "txtname"
        Me.txtname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtname.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtname.PlaceholderText = "Name"
        Me.txtname.SelectedText = ""
        Me.txtname.ShadowDecoration.Parent = Me.txtname
        Me.txtname.Size = New System.Drawing.Size(202, 50)
        Me.txtname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtname.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(744, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 22)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Stock :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(469, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 37)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Supplier Details"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(880, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 22)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Address :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(262, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 22)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Books :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(514, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 22)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Contact :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("hooge 05_53", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(925, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(304, 30)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Current data & time"
        '
        'txtsearch
        '
        Me.txtsearch.BorderRadius = 12
        Me.txtsearch.BorderThickness = 0
        Me.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsearch.DefaultText = ""
        Me.txtsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsearch.DisabledState.Parent = Me.txtsearch
        Me.txtsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsearch.FocusedState.Parent = Me.txtsearch
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsearch.HoverState.Parent = Me.txtsearch
        Me.txtsearch.IconLeft = Global.LibraryManagementSystemApp.My.Resources.Resources.search
        Me.txtsearch.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.txtsearch.Location = New System.Drawing.Point(940, 62)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsearch.PlaceholderText = "Search here...."
        Me.txtsearch.SelectedText = ""
        Me.txtsearch.ShadowDecoration.Parent = Me.txtsearch
        Me.txtsearch.Size = New System.Drawing.Size(289, 42)
        Me.txtsearch.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(18, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 22)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Name :"
        '
        'IssueDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1250, 790)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Guna2DataGridView1)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtstock)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.txtbooks)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtsearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "IssueDetails"
        Me.Text = "IssueDetails"
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnreset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btndelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnedit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnsave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtaddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtstock As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtcontact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtbooks As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtsearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
End Class
