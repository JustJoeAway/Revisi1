Imports System.Data.SqlClient

Public Class FormProfileMahasiswa

    Private Sub FormProfileDosen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usernamethis As String = FormLogin.TextBox1.Text

        Call Koneksi()
        CMD = New SqlCommand("Select * from TBL_Mahasiswa where NIM='" & usernamethis & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then

        Else
            Label11.Text = RD.Item("NIM")
            Label13.Text = RD.Item("Nama")
            Label14.Text = RD.Item("Kelas")
            Label15.Text = RD.Item("Jurusan")
            Label16.Text = RD.Item("TmptLhr")
            Label17.Text = RD.Item("TglLhr")
            Label18.Text = RD.Item("Alamat")
            Label19.Text = RD.Item("Jenis_Kelamin")
            Label20.Text = RD.Item("Agama")
            Label21.Text = RD.Item("No_HP")
            Label22.Text = RD.Item("Email")
            Label23.Text = RD.Item("Umur")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormUpdateMahasiswa.ShowDialog()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub
End Class