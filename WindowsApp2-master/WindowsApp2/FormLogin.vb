Imports System.Data.SqlClient
Public Class FormLogin
    Private Sub TextBox1_KeypPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Data Login belum lengkap")
            Exit Sub
        Else
            Call Koneksi()
            CMD = New SqlCommand("select * from TBL_User where Username='" & TextBox1.Text & "' and Password='" & TextBox2.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.Item("Type").ToString = "ADMIN" Then
                FormMasterAdmin.ShowDialog()
            ElseIf RD.Item("Type").ToString = "MAHASISWA" Then
                FormMahasiswa.ShowDialog()
            ElseIf RD.Item("Type").ToString = "DOSEN" Then
                FormDosen.ShowDialog()
            Else
                MsgBox("Usename atau Password salah")
            End If
        End If
    End Sub

    Private Sub TextBox2_KeypPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then Button1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Sub Terbuka()




    End Sub

    Private Sub FormLogin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        TextBox1.Focus()
    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub Switch(p1 As Object)
        Throw New NotImplementedException
    End Sub

    Private Sub Switch()
        Throw New NotImplementedException
    End Sub

End Class