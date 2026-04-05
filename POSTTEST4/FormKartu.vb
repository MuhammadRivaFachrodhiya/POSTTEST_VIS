Public Class FormKartu


    Public Sub New(nama As String, id As String, umur As Integer, divisi As String, kontak As String, aktivitas As String, peran As String, foto As Image)
        InitializeComponent()


        lblKartuNama.Text = nama.ToUpper()
        lblKartuID.Text = "ID: " & id & "  |  Umur: " & umur & " Tahun"
        lblKartuDivisi.Text = "Divisi: " & divisi
        lblKartuPeran.Text = "Peran: " & peran
        lblKartuKontak.Text = "Kontak: " & kontak
        lblKartuAktivitas.Text = "Aktivitas: " & aktivitas


        pbKartuFoto.Image = foto
    End Sub

    Private Sub FormKartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class