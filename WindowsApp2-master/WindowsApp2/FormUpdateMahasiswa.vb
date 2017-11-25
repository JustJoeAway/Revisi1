Imports System.Data.SqlClient
Public Class FormUpdateMahasiswa
    
    Private Sub txtKelas_TextChanged(sender As Object, e As EventArgs) Handles txtJenisKelamin.TextChanged

    End Sub

    Private Sub lblKelas_Click(sender As Object, e As EventArgs) Handles lblKelas.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtNIM_TextChanged(sender As Object, e As EventArgs) Handles txtUmur.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub



    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim usernamethis As String = FormLogin.TextBox1.Text
        If txtNama.Text = "" Or txtUmur.Text = "" Or txtJenisKelamin.Text = "" Or txtHari.Text = "" Or txtBulan.Text = "" Or txtTahun.Text = "" Or txtAlamat.Text = "" Or txtAgama.Text = "" Or txtNo_hp.Text = "" Or txtEmail.Text = "" Then
            MsgBox("Data belum lengkap, mohon diisi semua")
            Exit Sub
        Else
            Call Koneksi()
            Dim tanggal As String = txtTahun.Text & "-" & txtBulan.Text & "-" & txtHari.Text
            Dim zero As String = "0"
            Dim simpan As String = "Update TBL_Mahasiswa Set Nama='" & txtNama.Text & "', Umur='" & txtUmur.Text & "', Jenis_Kelamin='" & txtJenisKelamin.Text & "', TglLhr='" & tanggal & "', Alamat='" & txtAlamat.Text & "', Agama='" & txtAgama.Text & "', No_HP='" & txtNo_hp.Text & "', Email='" & txtEmail.Text & "', TmptLhr='" & TextBox1.Text & "' where NIM='" & usernamethis & "' "
            CMD = New SqlCommand(simpan, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")
        End If
    End Sub



    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub FormUpdateDosen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class