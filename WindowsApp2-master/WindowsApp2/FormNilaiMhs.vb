Imports System.Data.SqlClient
Public Class FormNilaiMhs :  form
    Sub TampilGrid()
        Call Koneksi()
        DA = New SqlDataAdapter("select * from TBL_User where Username like '%" & TextBox4.Text & "%'", CONN)
        DS = New DataSet
        DA.Fill(DS, "ketemu")
        DataGridView1.DataSource = DS.Tables("ketemu")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub FormMasterAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtNIM_Nilai_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class