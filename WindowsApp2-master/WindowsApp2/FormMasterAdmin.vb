Imports System.Data.SqlClient
Public Class FormMasterAdmin
    Sub Locked()
        txtMatkul.Enabled = False
    End Sub

    Sub TampilStatus()
        cmbMatkul.Items.Clear()
        cmbMatkul.Items.Add("ADMIN")
        cmbMatkul.Items.Add("DOSEN")
        cmbMatkul.Items.Add("MAHASISWA")
        cmbMatkul.SelectedItem = "ADMIN"
    End Sub
    Sub TampilGrid()
        Call Koneksi()
        DA = New SqlDataAdapter("select Username as NIM, Password as Password, Type as Tipe From TBL_User", CONN)
        DS = New DataSet
        DA.Fill(DS, "TBL_User")
        DataGridView1.DataSource = DS.Tables("TBL_User")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUser.Text = "" Or txtPass.Text = "" Or cmbMatkul.Text = "" Then
            MsgBox("Data belum lengkap, mohon diisi semua")
            Exit Sub
        Else
            Call Koneksi()
            Dim simpan2 As String
            Dim simpan3 As String
            If cmbMatkul.Text = "DOSEN" Then
                Dim simpan As String = "insert into TBL_User values ('" & txtUser.Text & "','" & txtPass.Text & "','" & cmbMatkul.Text & "')"
                simpan2 = "insert into TBL_Dosen (NIM,Matkul,Nama,Umur,Jenis_Kelamin,Tgl_Lahir,Alamat,Agama,No_Hp,Email) values ('" & txtUser.Text & "','" & txtMatkul.Text & "','00','00','00','1900-12-30','00','00','00','00')"
                CMD = New SqlCommand(simpan, CONN)
                CMD.ExecuteNonQuery()
                CMD = New SqlCommand(simpan2, CONN)
                CMD.ExecuteNonQuery()
            ElseIf cmbMatkul.Text = "MAHASISWA" Then
                Dim simpan As String = "insert into TBL_User values ('" & txtUser.Text & "','" & txtPass.Text & "','" & cmbMatkul.Text & "')"
                simpan3 = "insert into TBL_Mahasiswa ([NIM],[Nama],[Umur],[Jenis_Kelamin],[TglLhr],[Alamat],[Agama],[No_HP],[Email],[TmptLhr],[Jurusan],[Kelas]) values ('" & txtUser.Text & "','00','00','00','1900-12-30','00','00','00','00','00','00','00')"
                Dim simpan5 As String = "insert into TBL_Nilai Values('00','" & txtUser.Text & "','00','00','00','00','00','00','00')"
                CMD = New SqlCommand(simpan, CONN)
                CMD.ExecuteNonQuery()
                CMD = New SqlCommand(simpan3, CONN)
                CMD.ExecuteNonQuery()
                CMD = New SqlCommand(simpan5, CONN)
                CMD.ExecuteNonQuery()
            End If
            MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")
            Call TampilGrid()
        End If
    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If e.RowIndex > DataGridView1.Rows.Count() OrElse e.RowIndex < 0 OrElse DataGridView1.Rows(e.RowIndex) Is Nothing OrElse DataGridView1.Rows(e.RowIndex).DataBoundItem Is Nothing Then
            e.Value = Nothing
        ElseIf e.ColumnIndex = 2 Then
            e.Value = "*****"
        End If
    End Sub

    Private Sub FormMasterAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call TampilStatus()
        Call TampilGrid()
        Call Locked()
        txtUser.Focus()
        txtPass.PasswordChar = "*"
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Call Koneksi()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        CMD = New SqlCommand("Select * from TBL_User where Username='" & DataGridView1.Item(0, i).Value & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            txtUser.Focus()
        Else
            txtUser.Text = RD.Item("Username")
            txtPass.Text = RD.Item("Password")
            cmbMatkul.Text = RD.Item("Type")
            txtUser.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtUser.Text = "" Or txtPass.Text = "" Or cmbMatkul.Text = "" Then
            MsgBox("Data belum lengkap")
            Exit Sub
        Else
            Call Koneksi()
            Dim edit As String = "update TBL_User set Password='" & txtPass.Text & "',Type='" & cmbMatkul.Text & "' where Username='" & txtUser.Text & "'"
            CMD = New SqlCommand(edit, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di Edit", MsgBoxStyle.Information, "Information")
            Call TampilGrid()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtUser.Text = "" Or txtPass.Text = "" Or cmbMatkul.Text = "" Then
            MsgBox("Data Belum Lengkap!!")
            Exit Sub
        Else
            Call Koneksi()
            Dim hapus As String = "delete from TBL_User where Username='" & txtUser.Text & "'"
            CMD = New SqlCommand(hapus, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di Hapus", MsgBoxStyle.Information, "Information")
            Call TampilGrid()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Call Koneksi()
        CMD = New SqlCommand("select * from TBL_User where Username like '%" & TextBox4.Text & "%'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Call Koneksi()
            DA = New SqlDataAdapter("select * from TBL_User where Username like '%" & TextBox4.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS, "ketemu")
            DataGridView1.DataSource = DS.Tables("ketemu")
            DataGridView1.ReadOnly = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMatkul.SelectedIndexChanged
        If cmbMatkul.Text = "DOSEN" Then
            txtMatkul.Enabled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtMatkul.TextChanged

    End Sub
End Class