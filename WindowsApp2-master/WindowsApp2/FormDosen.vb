Imports System.Data.SqlClient

Public Class FormDosen
 

    Private Sub FormDosen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usernamethis As String = FormLogin.TextBox1.Text

        Call Koneksi()
        CMD = New SqlCommand("Select * from TBL_Dosen where NIM='" & usernamethis & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then

        Else
            lblDTnim.Text = RD.Item("NIM")
            lblDBmatkul.Text = RD.Item("Matkul")
        End If
    End Sub

    Private Sub btnprofile_Click(sender As Object, e As EventArgs) Handles btnprofile.Click
        FormProfileDosen.ShowDialog()
    End Sub
End Class