<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateMahasiswa
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
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblNIM = New System.Windows.Forms.Label()
        Me.lblKelas = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtUmur = New System.Windows.Forms.TextBox()
        Me.txtJenisKelamin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHari = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBulan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTahun = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAgama = New System.Windows.Forms.TextBox()
        Me.txtNo_hp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(14, 16)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(35, 13)
        Me.lblNama.TabIndex = 0
        Me.lblNama.Text = "Nama"
        '
        'lblNIM
        '
        Me.lblNIM.AutoSize = True
        Me.lblNIM.Location = New System.Drawing.Point(14, 42)
        Me.lblNIM.Name = "lblNIM"
        Me.lblNIM.Size = New System.Drawing.Size(32, 13)
        Me.lblNIM.TabIndex = 3
        Me.lblNIM.Text = "Umur"
        '
        'lblKelas
        '
        Me.lblKelas.AutoSize = True
        Me.lblKelas.Location = New System.Drawing.Point(14, 67)
        Me.lblKelas.Name = "lblKelas"
        Me.lblKelas.Size = New System.Drawing.Size(71, 13)
        Me.lblKelas.TabIndex = 5
        Me.lblKelas.Text = "Jenis Kelamin"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(107, 16)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(288, 20)
        Me.txtNama.TabIndex = 1
        '
        'txtUmur
        '
        Me.txtUmur.Location = New System.Drawing.Point(107, 42)
        Me.txtUmur.Name = "txtUmur"
        Me.txtUmur.Size = New System.Drawing.Size(135, 20)
        Me.txtUmur.TabIndex = 2
        '
        'txtJenisKelamin
        '
        Me.txtJenisKelamin.Location = New System.Drawing.Point(107, 67)
        Me.txtJenisKelamin.Name = "txtJenisKelamin"
        Me.txtJenisKelamin.Size = New System.Drawing.Size(135, 20)
        Me.txtJenisKelamin.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Tempat  /Tgl Lahir"
        '
        'txtHari
        '
        Me.txtHari.Location = New System.Drawing.Point(158, 93)
        Me.txtHari.Name = "txtHari"
        Me.txtHari.Size = New System.Drawing.Size(32, 20)
        Me.txtHari.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(192, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "/"
        '
        'txtBulan
        '
        Me.txtBulan.Location = New System.Drawing.Point(206, 93)
        Me.txtBulan.Name = "txtBulan"
        Me.txtBulan.Size = New System.Drawing.Size(32, 20)
        Me.txtBulan.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(240, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "/"
        '
        'txtTahun
        '
        Me.txtTahun.Location = New System.Drawing.Point(255, 93)
        Me.txtTahun.Name = "txtTahun"
        Me.txtTahun.Size = New System.Drawing.Size(57, 20)
        Me.txtTahun.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Alamat"
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(107, 119)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAlamat.Size = New System.Drawing.Size(342, 91)
        Me.txtAlamat.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Agama"
        '
        'txtAgama
        '
        Me.txtAgama.Location = New System.Drawing.Point(107, 217)
        Me.txtAgama.Name = "txtAgama"
        Me.txtAgama.Size = New System.Drawing.Size(135, 20)
        Me.txtAgama.TabIndex = 17
        '
        'txtNo_hp
        '
        Me.txtNo_hp.Location = New System.Drawing.Point(107, 243)
        Me.txtNo_hp.Name = "txtNo_hp"
        Me.txtNo_hp.Size = New System.Drawing.Size(135, 20)
        Me.txtNo_hp.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "No. HP"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(107, 269)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(135, 20)
        Me.txtEmail.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Email"
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(17, 308)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(86, 23)
        Me.btnInput.TabIndex = 25
        Me.btnInput.Text = "&Input"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(159, 308)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(86, 23)
        Me.btnTutup.TabIndex = 28
        Me.btnTutup.Text = "&Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(107, 94)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(45, 20)
        Me.TextBox1.TabIndex = 29
        '
        'FormUpdateMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 362)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNo_hp)
        Me.Controls.Add(Me.txtAgama)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTahun)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBulan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtHari)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblKelas)
        Me.Controls.Add(Me.txtJenisKelamin)
        Me.Controls.Add(Me.lblNIM)
        Me.Controls.Add(Me.txtUmur)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.lblNama)
        Me.Name = "FormUpdateMahasiswa"
        Me.Text = "FormUpdateMahasiswa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents lblNIM As Label
    Friend WithEvents lblKelas As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtJenisKelamin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHari As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBulan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAgama As TextBox
    Friend WithEvents txtNo_hp As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnInput As Button
    Friend WithEvents btnTutup As Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
