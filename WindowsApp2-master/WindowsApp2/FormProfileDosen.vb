Imports System.Data.SqlClient

Public Class FormProfileDosen

    Private Sub FormProfileDosen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usernamethis As String = FormLogin.TextBox1.Text

        Call Koneksi()
        CMD = New SqlCommand("Select * from TBL_Dosen where NIM='" & usernamethis & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then

        Else
            Label11.Text = RD.Item("NIM")
            Label12.Text = RD.Item("Matkul")
            Label13.Text = RD.Item("Nama")
            Label14.Text = RD.Item("Umur")
            Label15.Text = RD.Item("Jenis_Kelamin")
            Label16.Text = RD.Item("Tgl_Lahir")
            Label17.Text = RD.Item("Alamat")
            Label18.Text = RD.Item("Agama")
            Label19.Text = RD.Item("Email")
            Label20.Text = RD.Item("No_HP")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormUpdateDosen.ShowDialog()
    End Sub
End Class