<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtama
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        MenuInput = New ToolStripMenuItem()
        MenuLihat = New ToolStripMenuItem()
        MenuSimpan = New ToolStripMenuItem()
        MenuBuka = New ToolStripMenuItem()
        MenuKeluar = New ToolStripMenuItem()
        lblJudul = New Label()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        GroupBox1 = New GroupBox()
        txtNama = New TextBox()
        GroupBox2 = New GroupBox()
        txtID = New TextBox()
        GroupBox3 = New GroupBox()
        dtpTanggalLahir = New DateTimePicker()
        GroupBox4 = New GroupBox()
        cbDivisi = New ComboBox()
        GroupBox5 = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        TabPage2 = New TabPage()
        GroupBox6 = New GroupBox()
        mtbTelepon = New MaskedTextBox()
        GroupBox7 = New GroupBox()
        txtEmail = New TextBox()
        GroupBox8 = New GroupBox()
        txtAlamat = New TextBox()
        TabPage3 = New TabPage()
        btnSimpanCetak = New Button()
        gbAktivitas = New GroupBox()
        chk8 = New CheckBox()
        chk7 = New CheckBox()
        chk6 = New CheckBox()
        chk5 = New CheckBox()
        chk4 = New CheckBox()
        chk3 = New CheckBox()
        chk2 = New CheckBox()
        chk1 = New CheckBox()
        gbPeran = New GroupBox()
        rbAdmin = New RadioButton()
        rbAnggota = New RadioButton()
        rbKetua = New RadioButton()
        btnBrowse = New Button()
        pbProfil = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox5.SuspendLayout()
        TabPage2.SuspendLayout()
        GroupBox6.SuspendLayout()
        GroupBox7.SuspendLayout()
        GroupBox8.SuspendLayout()
        TabPage3.SuspendLayout()
        gbAktivitas.SuspendLayout()
        gbPeran.SuspendLayout()
        CType(pbProfil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuInput, MenuLihat, MenuSimpan, MenuBuka, MenuKeluar})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(600, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuInput
        ' 
        MenuInput.Name = "MenuInput"
        MenuInput.Size = New Size(74, 20)
        MenuInput.Text = "Input Data"
        ' 
        ' MenuLihat
        ' 
        MenuLihat.Name = "MenuLihat"
        MenuLihat.Size = New Size(76, 20)
        MenuLihat.Text = "Lihat Kartu"
        ' 
        ' MenuSimpan
        ' 
        MenuSimpan.Name = "MenuSimpan"
        MenuSimpan.Size = New Size(86, 20)
        MenuSimpan.Text = "Simpan Data"
        ' 
        ' MenuBuka
        ' 
        MenuBuka.Name = "MenuBuka"
        MenuBuka.Size = New Size(72, 20)
        MenuBuka.Text = "Buka Data"
        ' 
        ' MenuKeluar
        ' 
        MenuKeluar.Name = "MenuKeluar"
        MenuKeluar.Size = New Size(52, 20)
        MenuKeluar.Text = "Keluar"
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Lucida Bright", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.ForeColor = SystemColors.Control
        lblJudul.Location = New Point(223, 39)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(128, 27)
        lblJudul.TabIndex = 1
        lblJudul.Text = "ID CARD "
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Font = New Font("Lucida Fax", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(20, 80)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(550, 350)
        TabControl1.TabIndex = 2
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(GroupBox1)
        TabPage1.Controls.Add(GroupBox2)
        TabPage1.Controls.Add(GroupBox3)
        TabPage1.Controls.Add(GroupBox4)
        TabPage1.Controls.Add(GroupBox5)
        TabPage1.Location = New Point(4, 27)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(542, 319)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtNama)
        GroupBox1.Location = New Point(20, 6)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(494, 45)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Nama"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(6, 15)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama Lengkap"
        txtNama.Size = New Size(469, 26)
        txtNama.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtID)
        GroupBox2.Location = New Point(20, 57)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(494, 47)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "ID "
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(6, 18)
        txtID.Name = "txtID"
        txtID.PlaceholderText = "ID Anggota"
        txtID.Size = New Size(469, 26)
        txtID.TabIndex = 1
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(dtpTanggalLahir)
        GroupBox3.Location = New Point(20, 110)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(494, 48)
        GroupBox3.TabIndex = 9
        GroupBox3.TabStop = False
        GroupBox3.Text = "Tangal Lahir"
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Location = New Point(6, 19)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(469, 26)
        dtpTanggalLahir.TabIndex = 3
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(cbDivisi)
        GroupBox4.Location = New Point(283, 176)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(231, 100)
        GroupBox4.TabIndex = 10
        GroupBox4.TabStop = False
        GroupBox4.Text = "Divisi Anda"
        ' 
        ' cbDivisi
        ' 
        cbDivisi.FormattingEnabled = True
        cbDivisi.Items.AddRange(New Object() {"Head of Event", "Team Production", "IT & Developer", "Public Relations"})
        cbDivisi.Location = New Point(6, 22)
        cbDivisi.Name = "cbDivisi"
        cbDivisi.Size = New Size(212, 26)
        cbDivisi.TabIndex = 6
        cbDivisi.Text = "-- Pilih Divisi --"
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(rbPerempuan)
        GroupBox5.Controls.Add(rbLaki)
        GroupBox5.Location = New Point(20, 176)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(200, 100)
        GroupBox5.TabIndex = 11
        GroupBox5.TabStop = False
        GroupBox5.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(6, 57)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(118, 22)
        rbPerempuan.TabIndex = 5
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(6, 22)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(94, 22)
        rbLaki.TabIndex = 4
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(GroupBox6)
        TabPage2.Controls.Add(GroupBox7)
        TabPage2.Controls.Add(GroupBox8)
        TabPage2.Location = New Point(4, 27)
        TabPage2.Name = "TabPage2"
        TabPage2.Size = New Size(542, 319)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & Info"
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(mtbTelepon)
        GroupBox6.Location = New Point(20, 20)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(497, 84)
        GroupBox6.TabIndex = 3
        GroupBox6.TabStop = False
        GroupBox6.Text = "Nomor HP"
        ' 
        ' mtbTelepon
        ' 
        mtbTelepon.Location = New Point(17, 35)
        mtbTelepon.Mask = "0000-0000-00000"
        mtbTelepon.Name = "mtbTelepon"
        mtbTelepon.Size = New Size(458, 26)
        mtbTelepon.TabIndex = 0
        ' 
        ' GroupBox7
        ' 
        GroupBox7.Controls.Add(txtEmail)
        GroupBox7.Location = New Point(20, 110)
        GroupBox7.Name = "GroupBox7"
        GroupBox7.Size = New Size(497, 82)
        GroupBox7.TabIndex = 4
        GroupBox7.TabStop = False
        GroupBox7.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(17, 34)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Gunakan Format @gmail.com"
        txtEmail.Size = New Size(458, 26)
        txtEmail.TabIndex = 1
        ' 
        ' GroupBox8
        ' 
        GroupBox8.Controls.Add(txtAlamat)
        GroupBox8.Location = New Point(20, 208)
        GroupBox8.Name = "GroupBox8"
        GroupBox8.Size = New Size(497, 100)
        GroupBox8.TabIndex = 5
        GroupBox8.TabStop = False
        GroupBox8.Text = "Alamat"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(17, 33)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.PlaceholderText = "Alamat Lengkap"
        txtAlamat.Size = New Size(458, 61)
        txtAlamat.TabIndex = 2
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(btnSimpanCetak)
        TabPage3.Controls.Add(gbAktivitas)
        TabPage3.Controls.Add(gbPeran)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(pbProfil)
        TabPage3.Location = New Point(4, 27)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(542, 319)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktivitas"
        ' 
        ' btnSimpanCetak
        ' 
        btnSimpanCetak.BackColor = Color.LightBlue
        btnSimpanCetak.Font = New Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpanCetak.Location = New Point(140, 250)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(380, 40)
        btnSimpanCetak.TabIndex = 4
        btnSimpanCetak.Text = "SIMPAN && CETAK KARTU"
        btnSimpanCetak.UseVisualStyleBackColor = False
        ' 
        ' gbAktivitas
        ' 
        gbAktivitas.Controls.Add(chk8)
        gbAktivitas.Controls.Add(chk7)
        gbAktivitas.Controls.Add(chk6)
        gbAktivitas.Controls.Add(chk5)
        gbAktivitas.Controls.Add(chk4)
        gbAktivitas.Controls.Add(chk3)
        gbAktivitas.Controls.Add(chk2)
        gbAktivitas.Controls.Add(chk1)
        gbAktivitas.Location = New Point(140, 80)
        gbAktivitas.Name = "gbAktivitas"
        gbAktivitas.Size = New Size(380, 150)
        gbAktivitas.TabIndex = 3
        gbAktivitas.TabStop = False
        gbAktivitas.Text = "Aktivitas / Hobi"
        ' 
        ' chk8
        ' 
        chk8.Location = New Point(180, 100)
        chk8.Name = "chk8"
        chk8.Size = New Size(150, 20)
        chk8.TabIndex = 0
        chk8.Text = "Artificial Intelligence"
        ' 
        ' chk7
        ' 
        chk7.Location = New Point(180, 75)
        chk7.Name = "chk7"
        chk7.Size = New Size(150, 20)
        chk7.TabIndex = 1
        chk7.Text = "Project Management"
        ' 
        ' chk6
        ' 
        chk6.Location = New Point(180, 50)
        chk6.Name = "chk6"
        chk6.Size = New Size(150, 20)
        chk6.TabIndex = 2
        chk6.Text = "Data Mining"
        ' 
        ' chk5
        ' 
        chk5.Location = New Point(180, 25)
        chk5.Name = "chk5"
        chk5.Size = New Size(150, 20)
        chk5.TabIndex = 3
        chk5.Text = "Musik / Vinyl"
        ' 
        ' chk4
        ' 
        chk4.Location = New Point(20, 100)
        chk4.Name = "chk4"
        chk4.Size = New Size(150, 20)
        chk4.TabIndex = 4
        chk4.Text = "Bermain Game"
        ' 
        ' chk3
        ' 
        chk3.Location = New Point(20, 75)
        chk3.Name = "chk3"
        chk3.Size = New Size(150, 20)
        chk3.TabIndex = 5
        chk3.Text = "Event Organizing"
        ' 
        ' chk2
        ' 
        chk2.Location = New Point(20, 50)
        chk2.Name = "chk2"
        chk2.Size = New Size(150, 20)
        chk2.TabIndex = 6
        chk2.Text = "Desain UI/UX"
        ' 
        ' chk1
        ' 
        chk1.Location = New Point(20, 25)
        chk1.Name = "chk1"
        chk1.Size = New Size(150, 20)
        chk1.TabIndex = 7
        chk1.Text = "Web Development"
        ' 
        ' gbPeran
        ' 
        gbPeran.Controls.Add(rbAdmin)
        gbPeran.Controls.Add(rbAnggota)
        gbPeran.Controls.Add(rbKetua)
        gbPeran.Location = New Point(140, 20)
        gbPeran.Name = "gbPeran"
        gbPeran.Size = New Size(380, 50)
        gbPeran.TabIndex = 2
        gbPeran.TabStop = False
        gbPeran.Text = "Peran"
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(220, 20)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(80, 22)
        rbAdmin.TabIndex = 2
        rbAdmin.Text = "Admin"
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(120, 20)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(93, 22)
        rbAnggota.TabIndex = 1
        rbAnggota.Text = "Anggota"
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(20, 20)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(72, 22)
        rbKetua.TabIndex = 0
        rbKetua.Text = "Ketua"
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(20, 130)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(100, 23)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse Foto..."
        ' 
        ' pbProfil
        ' 
        pbProfil.BorderStyle = BorderStyle.FixedSingle
        pbProfil.Location = New Point(20, 20)
        pbProfil.Name = "pbProfil"
        pbProfil.Size = New Size(100, 100)
        pbProfil.SizeMode = PictureBoxSizeMode.Zoom
        pbProfil.TabIndex = 0
        pbProfil.TabStop = False
        ' 
        ' FormUtama
        ' 
        BackColor = Color.Gray
        ClientSize = New Size(600, 450)
        Controls.Add(TabControl1)
        Controls.Add(lblJudul)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "FormUtama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistem Manajemen Komunitas"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        TabPage2.ResumeLayout(False)
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        GroupBox7.ResumeLayout(False)
        GroupBox7.PerformLayout()
        GroupBox8.ResumeLayout(False)
        GroupBox8.PerformLayout()
        TabPage3.ResumeLayout(False)
        gbAktivitas.ResumeLayout(False)
        gbPeran.ResumeLayout(False)
        gbPeran.PerformLayout()
        CType(pbProfil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuInput As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuLihat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSimpan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuBuka As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuKeluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents cbDivisi As System.Windows.Forms.ComboBox
    Friend WithEvents rbPerempuan As System.Windows.Forms.RadioButton
    Friend WithEvents rbLaki As System.Windows.Forms.RadioButton
    Friend WithEvents dtpTanggalLahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents mtbTelepon As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnSimpanCetak As System.Windows.Forms.Button
    Friend WithEvents gbAktivitas As System.Windows.Forms.GroupBox
    Friend WithEvents chk8 As System.Windows.Forms.CheckBox
    Friend WithEvents chk7 As System.Windows.Forms.CheckBox
    Friend WithEvents chk6 As System.Windows.Forms.CheckBox
    Friend WithEvents chk5 As System.Windows.Forms.CheckBox
    Friend WithEvents chk4 As System.Windows.Forms.CheckBox
    Friend WithEvents chk3 As System.Windows.Forms.CheckBox
    Friend WithEvents chk2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk1 As System.Windows.Forms.CheckBox
    Friend WithEvents gbPeran As System.Windows.Forms.GroupBox
    Friend WithEvents rbAdmin As System.Windows.Forms.RadioButton
    Friend WithEvents rbAnggota As System.Windows.Forms.RadioButton
    Friend WithEvents rbKetua As System.Windows.Forms.RadioButton
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents pbProfil As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox

End Class