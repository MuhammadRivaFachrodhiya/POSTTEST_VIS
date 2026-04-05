<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKartu
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
        pbKartuFoto = New PictureBox()
        lblKartuNama = New Label()
        lblKartuID = New Label()
        lblKartuDivisi = New Label()
        lblKartuPeran = New Label()
        lblKartuKontak = New Label()
        lblKartuAktivitas = New Label()
        CType(pbKartuFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbKartuFoto
        ' 
        pbKartuFoto.BorderStyle = BorderStyle.FixedSingle
        pbKartuFoto.Location = New Point(120, 20)
        pbKartuFoto.Name = "pbKartuFoto"
        pbKartuFoto.Size = New Size(120, 120)
        pbKartuFoto.SizeMode = PictureBoxSizeMode.Zoom
        pbKartuFoto.TabIndex = 0
        pbKartuFoto.TabStop = False
        ' 
        ' lblKartuNama
        ' 
        lblKartuNama.Font = New Font("Lucida Fax", 9.75F)
        lblKartuNama.ForeColor = Color.White
        lblKartuNama.Location = New Point(10, 160)
        lblKartuNama.Name = "lblKartuNama"
        lblKartuNama.Size = New Size(340, 25)
        lblKartuNama.TabIndex = 1
        lblKartuNama.Text = "Nama"
        lblKartuNama.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblKartuID
        ' 
        lblKartuID.Font = New Font("Lucida Fax", 9.75F)
        lblKartuID.ForeColor = Color.LightGray
        lblKartuID.Location = New Point(10, 190)
        lblKartuID.Name = "lblKartuID"
        lblKartuID.Size = New Size(340, 20)
        lblKartuID.TabIndex = 2
        lblKartuID.Text = "ID Anggota"
        lblKartuID.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblKartuDivisi
        ' 
        lblKartuDivisi.Font = New Font("Lucida Fax", 9.75F)
        lblKartuDivisi.ForeColor = Color.White
        lblKartuDivisi.Location = New Point(20, 240)
        lblKartuDivisi.Name = "lblKartuDivisi"
        lblKartuDivisi.Size = New Size(320, 20)
        lblKartuDivisi.TabIndex = 3
        lblKartuDivisi.Text = "Divisi"
        ' 
        ' lblKartuPeran
        ' 
        lblKartuPeran.Font = New Font("Lucida Fax", 9.75F)
        lblKartuPeran.ForeColor = Color.White
        lblKartuPeran.Location = New Point(20, 270)
        lblKartuPeran.Name = "lblKartuPeran"
        lblKartuPeran.Size = New Size(320, 20)
        lblKartuPeran.TabIndex = 4
        lblKartuPeran.Text = "Peran"
        ' 
        ' lblKartuKontak
        ' 
        lblKartuKontak.Font = New Font("Lucida Fax", 9.75F)
        lblKartuKontak.ForeColor = Color.White
        lblKartuKontak.Location = New Point(20, 300)
        lblKartuKontak.Name = "lblKartuKontak"
        lblKartuKontak.Size = New Size(320, 20)
        lblKartuKontak.TabIndex = 5
        lblKartuKontak.Text = "Kontak"
        ' 
        ' lblKartuAktivitas
        ' 
        lblKartuAktivitas.Font = New Font("Lucida Fax", 9.75F)
        lblKartuAktivitas.ForeColor = Color.White
        lblKartuAktivitas.Location = New Point(20, 330)
        lblKartuAktivitas.Name = "lblKartuAktivitas"
        lblKartuAktivitas.Size = New Size(320, 50)
        lblKartuAktivitas.TabIndex = 6
        lblKartuAktivitas.Text = "Aktivitas"
        ' 
        ' FormKartu
        ' 
        BackColor = Color.FromArgb(CByte(20), CByte(30), CByte(50))
        ClientSize = New Size(360, 420)
        Controls.Add(lblKartuAktivitas)
        Controls.Add(lblKartuKontak)
        Controls.Add(lblKartuPeran)
        Controls.Add(lblKartuDivisi)
        Controls.Add(lblKartuID)
        Controls.Add(lblKartuNama)
        Controls.Add(pbKartuFoto)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FormKartu"
        StartPosition = FormStartPosition.CenterParent
        Text = "ID Card Komunitas"
        CType(pbKartuFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pbKartuFoto As System.Windows.Forms.PictureBox
    Friend WithEvents lblKartuNama As System.Windows.Forms.Label
    Friend WithEvents lblKartuID As System.Windows.Forms.Label
    Friend WithEvents lblKartuDivisi As System.Windows.Forms.Label
    Friend WithEvents lblKartuPeran As System.Windows.Forms.Label
    Friend WithEvents lblKartuKontak As System.Windows.Forms.Label
    Friend WithEvents lblKartuAktivitas As System.Windows.Forms.Label

End Class