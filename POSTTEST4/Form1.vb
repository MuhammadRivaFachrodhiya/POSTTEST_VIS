Imports System.IO

Public Class FormUtama

    Private ErrorProvider1 As New ErrorProvider()


    Private isDataTercetak As Boolean = False

    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddHandler MenuInput.Click, Sub() TabControl1.SelectedTab = TabPage1
        AddHandler MenuLihat.Click, AddressOf LihatKartuMenu
        AddHandler MenuSimpan.Click, AddressOf SimpanDataFile
        AddHandler MenuBuka.Click, AddressOf BukaDataFile
        AddHandler MenuKeluar.Click, AddressOf KeluarAplikasi

        ErrorProvider1.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError
    End Sub


    Private Sub LihatKartuMenu()
        If isDataTercetak = False Then
            MessageBox.Show("Anda belum mencetak kartu! Silakan isi data dan tekan tombol 'Simpan & Cetak Kartu' terlebih dahulu.", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim peran As String = "Anggota"
            If rbKetua.Checked Then peran = "Ketua"
            If rbAdmin.Checked Then peran = "Admin"

            Dim listAktivitas As New List(Of String)
            For Each ctrl As Control In gbAktivitas.Controls
                If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                    listAktivitas.Add(ctrl.Text)
                End If
            Next
            Dim aktivitasGabungan As String = String.Join(", ", listAktivitas)

            Dim frmKartu As New FormKartu(txtNama.Text, txtID.Text, GetUmur(), cbDivisi.Text, mtbTelepon.Text, aktivitasGabungan, peran, pbProfil.Image)
            frmKartu.ShowDialog()
        End If
    End Sub


    Private Function GetUmur() As Integer
        Dim tanggalLahir As DateTime = dtpTanggalLahir.Value
        Dim umur As Integer = DateTime.Now.Year - tanggalLahir.Year

        If DateTime.Now < tanggalLahir.AddYears(umur) Then
            umur -= 1
        End If

        If umur < 0 Then umur = 0
        Return umur
    End Function


    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pbProfil.Image = Image.FromFile(OpenFileDialog1.FileName)
            ErrorProvider1.SetError(btnBrowse, "")
        End If
    End Sub


    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        ErrorProvider1.Clear()
        Dim isValid As Boolean = True

        If String.IsNullOrWhiteSpace(txtNama.Text) OrElse txtNama.Text = "Nama Lengkap" Then
            ErrorProvider1.SetError(txtNama, "Inputan tidak boleh kosong!")
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(txtID.Text) OrElse txtID.Text = "ID Anggota" Then
            ErrorProvider1.SetError(txtID, "Inputan tidak boleh kosong!")
            isValid = False
        End If

        If cbDivisi.SelectedIndex = -1 OrElse cbDivisi.Text = "-- Pilih Divisi --" Then
            ErrorProvider1.SetError(cbDivisi, "Inputan tidak boleh kosong!")
            isValid = False
        End If


        If Not mtbTelepon.MaskCompleted Then
            ErrorProvider1.SetError(mtbTelepon, "Format nomor telepon tidak lengkap!")
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(txtEmail.Text) OrElse txtEmail.Text = "Email" Then
            ErrorProvider1.SetError(txtEmail, "Inputan tidak boleh kosong!")
            isValid = False
        ElseIf Not txtEmail.Text.Contains("@") Then
            ErrorProvider1.SetError(txtEmail, "Format email tidak valid! Harus mengandung karakter '@'.")
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(txtAlamat.Text) OrElse txtAlamat.Text = "Alamat Lengkap" Then
            ErrorProvider1.SetError(txtAlamat, "Inputan tidak boleh kosong!")
            isValid = False
        End If


        Dim listAktivitas As New List(Of String)
        For Each ctrl As Control In gbAktivitas.Controls
            If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                listAktivitas.Add(ctrl.Text)
            End If
        Next

        If listAktivitas.Count = 0 Then
            ErrorProvider1.SetError(gbAktivitas, "Inputan tidak boleh kosong! Pilih minimal 1.")
            isValid = False
        End If

        If pbProfil.Image Is Nothing Then
            ErrorProvider1.SetError(btnBrowse, "Inputan tidak boleh kosong!")
            isValid = False
        End If


        If Not isValid Then
            MessageBox.Show("Terdapat inputan yang masih kosong atau tidak valid. Silakan periksa tanda merah (Error Provider).", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        Dim result As DialogResult = MessageBox.Show("Data sudah lengkap. Apakah Anda yakin ingin mencetak kartu?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim peran As String = "Anggota"
            If rbKetua.Checked Then peran = "Ketua"
            If rbAdmin.Checked Then peran = "Admin"

            Dim aktivitasGabungan As String = String.Join(", ", listAktivitas)
            isDataTercetak = True

            Dim frmKartu As New FormKartu(txtNama.Text, txtID.Text, GetUmur(), cbDivisi.Text, mtbTelepon.Text, aktivitasGabungan, peran, pbProfil.Image)
            frmKartu.ShowDialog()
        End If
    End Sub

    Private Sub SimpanDataFile()
        SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Using sw As New StreamWriter(SaveFileDialog1.FileName)
                sw.WriteLine($"Nama: {txtNama.Text}")
                sw.WriteLine($"ID: {txtID.Text}")
                sw.WriteLine($"Divisi: {cbDivisi.Text}")
                sw.WriteLine($"Umur: {GetUmur()} Tahun")
                sw.WriteLine($"Telepon: {mtbTelepon.Text}")
            End Using
            MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BukaDataFile()
        OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim isiFile As String = File.ReadAllText(OpenFileDialog1.FileName)
            MessageBox.Show(isiFile, "Isi Data Tersimpan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub KeluarAplikasi()
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class