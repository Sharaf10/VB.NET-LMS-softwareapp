Imports MySql.Data.MySqlClient
Public Class FormMain
    Private Sub TotalMembers()
        conn.Open()
        Dim query = "SELECT count(*) FROM librarydb.tblmember;"
        Dim COMMAND As MySqlCommand
        COMMAND = New MySqlCommand(query, conn)
        Dim table As DataTable
        table = New DataTable
        Dim adapter As New MySqlDataAdapter(COMMAND)
        adapter = New MySqlDataAdapter(COMMAND)
        adapter.Fill(table)
        For Each dr As DataRow In table.Rows
            lblmember.Text = dr(0).ToString()
        Next
        conn.Close()
    End Sub

    Private Sub TotalBooks()
        conn.Open()
        Dim query = "SELECT count(*) FROM librarydb.tblbooks;"
        Dim COMMAND As MySqlCommand
        COMMAND = New MySqlCommand(query, conn)
        Dim table As DataTable
        table = New DataTable
        Dim adapter As New MySqlDataAdapter(COMMAND)
        adapter = New MySqlDataAdapter(COMMAND)
        adapter.Fill(table)
        For Each dr As DataRow In table.Rows
            lblbooks.Text = dr(0).ToString()
        Next
        conn.Close()
    End Sub

    Private Sub TotalStaff()
        conn.Open()
        Dim query = "SELECT count(*) FROM librarydb.tblstaff;"
        Dim COMMAND As MySqlCommand
        COMMAND = New MySqlCommand(query, conn)
        Dim table As DataTable
        table = New DataTable
        Dim adapter As New MySqlDataAdapter(COMMAND)
        adapter = New MySqlDataAdapter(COMMAND)
        adapter.Fill(table)
        For Each dr As DataRow In table.Rows
            lblstaff.Text = dr(0).ToString()
        Next
        conn.Close()
    End Sub

    Private Sub TotalSuppliers()
        conn.Open()
        Dim query = "SELECT count(*) FROM librarydb.tblsupplier;"
        Dim COMMAND As MySqlCommand
        COMMAND = New MySqlCommand(query, conn)
        Dim table As DataTable
        table = New DataTable
        Dim adapter As New MySqlDataAdapter(COMMAND)
        adapter = New MySqlDataAdapter(COMMAND)
        adapter.Fill(table)
        For Each dr As DataRow In table.Rows
            lblsuppliers.Text = dr(0).ToString()
        Next
        conn.Close()
    End Sub

    Private Sub TotalIssues()
        conn.Open()
        Dim query = "SELECT count(*) FROM librarydb.tblissue;"
        Dim COMMAND As MySqlCommand
        COMMAND = New MySqlCommand(query, conn)
        Dim table As DataTable
        table = New DataTable
        Dim adapter As New MySqlDataAdapter(COMMAND)
        adapter = New MySqlDataAdapter(COMMAND)
        adapter.Fill(table)
        For Each dr As DataRow In table.Rows
            lblIssue.Text = dr(0).ToString()
        Next
        conn.Close()
    End Sub

    Private Sub TotalReturns()
        conn.Open()
        Dim query = "SELECT count(*) FROM librarydb.tblreturn;"
        Dim COMMAND As MySqlCommand
        COMMAND = New MySqlCommand(query, conn)
        Dim table As DataTable
        table = New DataTable
        Dim adapter As New MySqlDataAdapter(COMMAND)
        adapter = New MySqlDataAdapter(COMMAND)
        adapter.Fill(table)
        For Each dr As DataRow In table.Rows
            lblreturn.Text = dr(0).ToString()
        Next
        conn.Close()
    End Sub

    'Private Sub TotalReports()
    'conn.Open()
    'Dim query = "SELECT count(*) FROM librarydb;"
    'Dim COMMAND As MySqlCommand
    'COMMAND = New MySqlCommand(query, conn)
    'Dim table As DataTable
    'table = New DataTable
    'Dim adapter As New MySqlDataAdapter(COMMAND)
    'adapter = New MySqlDataAdapter(COMMAND)
    'adapter.Fill(table)
    'For Each dr As DataRow In table.Rows
    '    lblreports.Text = dr(0).ToString()
    'Next
    'conn.Close()
    'End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        TotalMembers()
        TotalBooks()
        TotalStaff()
        TotalSuppliers()
        TotalIssues()
        TotalReturns()
        'TotalReports()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")
    End Sub
    Private Sub Guna2ControlBox1_Click_1(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click

    End Sub


    Private Sub Guna2Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2ControlBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2ControlBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuCustomLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Separator1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnsettings_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnsuppliers_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnreturn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnissue_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnstaff_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnbooks_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnmembers_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2Panel11_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuCustomLabel14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuCustomLabel15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Panel10_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuCustomLabel12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuCustomLabel13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Panel7_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2Panel13_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuCustomLabel18_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuCustomLabel19_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Panel12_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuCustomLabel16_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuCustomLabel17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Panel8_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuCustomLabel10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuCustomLabel11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Panel6_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuCustomLabel6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuCustomLabel7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Panel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuCustomLabel5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuCustomLabel4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuCustomLabel3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuCustomLabel2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Panel9_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2Panel14_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnsuppliers_Click_1(sender As Object, e As EventArgs) Handles btnsuppliers.Click
        SupplierDetails.Show()
        Me.Hide()
    End Sub

    Private Sub btnmembers_Click_1(sender As Object, e As EventArgs) Handles btnmembers.Click
        MemberDetails.Show()
        Me.Hide()
    End Sub

    Private Sub btnbooks_Click_1(sender As Object, e As EventArgs) Handles btnbooks.Click
        BookDetails.Show()
        Me.Hide()
    End Sub

    Private Sub btnstaff_Click_1(sender As Object, e As EventArgs) Handles btnstaff.Click
        StaffDetails.Show()
        Me.Hide()
    End Sub

    Private Sub btnissue_Click_1(sender As Object, e As EventArgs) Handles btnissue.Click
        IssueDetails.Show()
        Me.Hide()
    End Sub

    Private Sub btnreturn_Click_1(sender As Object, e As EventArgs) Handles btnreturn.Click
        ReturnDetails.Show()
        Me.Hide()
    End Sub

    Private Sub btnhome_Click_1(sender As Object, e As EventArgs) Handles btnhome.Click

    End Sub

    Private Sub Label10_Click_1(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
    End Sub

    Private Sub btnsettings_Click_1(sender As Object, e As EventArgs) Handles btnsettings.Click
        FormAbout.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuCustomLabel14_Click_1(sender As Object, e As EventArgs) Handles lblreports.Click

    End Sub

    Private Sub lblmember_Click(sender As Object, e As EventArgs) Handles lblmember.Click

    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Close()
        FormLogin.Show()
        FormLogin.txtusername.Clear()
        FormLogin.txtpassword.Clear()
    End Sub
End Class