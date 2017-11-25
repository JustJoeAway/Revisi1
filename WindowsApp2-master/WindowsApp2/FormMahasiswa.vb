Imports System.Data.SqlClient
Public Class FormMahasiswa2
    Private Sub FormMahasiswa2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim usernamethis As String = FormLogin.TextBox1.Text

        Call Koneksi()
        CMD = New SqlCommand("Select * from TBL_Mahasiswa where NIM='" & usernamethis & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then

        Else
            Label4.Text = RD.Item("Nama")
            Label5.Text = RD.Item("NIM")
            Label6.Text = RD.Item("Kelas")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormProfileMahasiswa.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class