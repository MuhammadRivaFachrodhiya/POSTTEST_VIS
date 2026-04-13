Public Class Admin

    Private selectedID As Integer = -1
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        TampilLamaran()
        UpdateDashboard()
        TampilStatistik()
        BersihkanForm()
        ApplyCustomStyle(Guna2DataGridView1)
        ApplyCustomStyle(Guna2DataGridView2)
        ApplyCustomStyle(Guna2DataGridView3)
    End Sub

    Private Sub TampilLamaran()
        Guna2DataGridView3.DataSource = DataModule.GetLamaranMenunggu()

        If Guna2DataGridView3.Columns.Count > 0 Then
            Guna2DataGridView3.Columns("id").Visible = False
            Guna2DataGridView3.Columns("nama").HeaderText = "Nama Pelamar"
            Guna2DataGridView3.Columns("alasan_melamar").HeaderText = "Alasan Melamar"
        End If
    End Sub

    Private Sub TampilData()
        Guna2DataGridView1.DataSource = DataModule.GetAllPanitia()

        If Guna2DataGridView1.Columns.Count > 0 Then
            Guna2DataGridView1.Columns("id").HeaderText = "ID"
            Guna2DataGridView1.Columns("nama").HeaderText = "Nama"
            Guna2DataGridView1.Columns("alamat").HeaderText = "Alamat"
            Guna2DataGridView1.Columns("nomorHP").HeaderText = "Nomor HP"
            Guna2DataGridView1.Columns("divisi").HeaderText = "Divisi"
            Guna2DataGridView1.Columns("email").HeaderText = "Email"

            Guna2DataGridView1.Columns("id").Visible = False
        End If
    End Sub

    Private Sub BersihkanForm()
        txtNama.Clear()
        txtAlamat.Clear()
        txtNomorHP.Clear()
        txtEmail.Clear()
        cbDivisi.SelectedIndex = -1
        cbDivisi.Text = ""
        ErrorProvider1.Clear()
        selectedID = -1
        txtNama.Focus()
    End Sub

    Private Sub IsiFormDariGrid(rowIndex As Integer)
        If rowIndex < 0 Then Exit Sub

        Try
            Dim row As DataGridViewRow = Guna2DataGridView1.Rows(rowIndex)

            selectedID = Convert.ToInt32(row.Cells("id").Value)
            txtNama.Text = row.Cells("nama").Value.ToString()
            txtAlamat.Text = row.Cells("alamat").Value.ToString()
            txtNomorHP.Text = row.Cells("nomorHP").Value.ToString()
            txtEmail.Text = row.Cells("email").Value.ToString()

            Dim divisi As String = row.Cells("divisi").Value.ToString()
            Dim idx As Integer = cbDivisi.FindStringExact(divisi)
            If idx >= 0 Then
                cbDivisi.SelectedIndex = idx
            Else
                cbDivisi.Text = divisi
            End If

            ErrorProvider1.Clear()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        ErrorProvider1.Clear()

        If Not ValidationModule.ValidasiDataPanitia(
            ErrorProvider1, txtNama, txtAlamat, txtNomorHP, cbDivisi, txtEmail
        ) Then Exit Sub

        If DataModule.SimpanPanitia(
            txtNama.Text.Trim(),
            txtAlamat.Text.Trim(),
            txtNomorHP.Text.Trim(),
            cbDivisi.Text,
            txtEmail.Text.Trim()
        ) Then
            MessageBox.Show("Data panitia berhasil disimpan!", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            BersihkanForm()
            UpdateDashboard()
            TampilStatistik()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If selectedID = -1 Then
            MessageBox.Show("Pilih data panitia yang ingin diubah terlebih dahulu!",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ErrorProvider1.Clear()

        If Not ValidationModule.ValidasiDataPanitia(
            ErrorProvider1, txtNama, txtAlamat, txtNomorHP, cbDivisi, txtEmail
        ) Then Exit Sub

        If DataModule.UbahPanitia(
            selectedID,
            txtNama.Text.Trim(),
            txtAlamat.Text.Trim(),
            txtNomorHP.Text.Trim(),
            cbDivisi.Text,
            txtEmail.Text.Trim()
        ) Then
            MessageBox.Show("Data panitia berhasil diubah!", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            BersihkanForm()
            UpdateDashboard()
            TampilStatistik()
        Else
            MessageBox.Show("Data tidak ditemukan.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedID = -1 Then
            MessageBox.Show("Pilih data panitia yang ingin dihapus terlebih dahulu!",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim konfirmasi As DialogResult =
            MessageBox.Show("Yakin ingin menghapus panitia ini?", "Konfirmasi Hapus",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            If DataModule.HapusPanitia(selectedID) Then
                MessageBox.Show("Data panitia berhasil dihapus!", "Informasi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                BersihkanForm()
                UpdateDashboard()
                TampilStatistik()
            End If
        End If
    End Sub

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        TampilData()
        BersihkanForm()
        TampilStatistik()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Dim keyword As String = Guna2TextBox1.Text.Trim()

        If String.IsNullOrWhiteSpace(keyword) Then
            TampilData()
            Exit Sub
        End If

        Dim idCari As Integer
        If Integer.TryParse(keyword, idCari) Then
            Dim dt As DataTable = DataModule.GetPanitiaByID(idCari)
            If dt.Rows.Count = 0 Then
                MessageBox.Show("Panitia dengan ID " & idCari & " tidak ditemukan.",
                                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Guna2DataGridView1.DataSource = dt
        Else
            Dim dt As DataTable = DataModule.SearchPanitia(keyword)
            If dt.Rows.Count = 0 Then
                MessageBox.Show("Tidak ada panitia yang cocok dengan kata kunci tersebut.",
                                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Guna2DataGridView1.DataSource = dt
        End If
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        Dim keyword As String = Guna2TextBox1.Text.Trim()

        If String.IsNullOrWhiteSpace(keyword) Then
            TampilData()
        Else
            Dim idCari As Integer
            If Integer.TryParse(keyword, idCari) Then
                Guna2DataGridView1.DataSource = DataModule.GetPanitiaByID(idCari)
            Else
                Guna2DataGridView1.DataSource = DataModule.SearchPanitia(keyword)
            End If
        End If
    End Sub

    Private Sub Guna2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox1.KeyPress
        If ValidationModule.IsEnterKey(e) Then
            e.Handled = True
            btnCari_Click(sender, e)
        End If
    End Sub

    Private Sub Guna2DataGridView1_CellClick(sender As Object,
        e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        IsiFormDariGrid(e.RowIndex)
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object,
        e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        IsiFormDariGrid(e.RowIndex)
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If ValidationModule.IsEnterKey(e) Then
            e.Handled = True
            txtAlamat.Focus()
        End If
    End Sub

    Private Sub txtAlamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlamat.KeyPress
        If ValidationModule.IsEnterKey(e) Then
            e.Handled = True
            txtNomorHP.Focus()
        End If
    End Sub

    Private Sub txtNomorHP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomorHP.KeyPress
        ValidationModule.HanyaAngkaHP(e)

        If ValidationModule.IsEnterKey(e) Then
            e.Handled = True
            cbDivisi.Focus()
        End If
    End Sub

    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        If ValidationModule.IsEnterKey(e) Then
            e.Handled = True
            btnTambah.Focus()
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub TP_HomeAdmin_Click(sender As Object, e As EventArgs) Handles TP_HomeAdmin.Click
    End Sub

    Private Sub txtIndeks_TextChanged(sender As Object, e As EventArgs) Handles txtIndeks.TextChanged
    End Sub

    Private Sub Guna2DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView3.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = Guna2DataGridView3.Rows(e.RowIndex)
            txtIndeks.Text = row.Cells("id").Value.ToString()
        End If
    End Sub

    Private Sub btnTerima_Click(sender As Object, e As EventArgs) Handles btnTerima.Click
        If txtIndeks.Text = "" Then
            MessageBox.Show("Silakan pilih lamaran yang ingin dikonfirmasi pada tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim idLamaran As Integer = Convert.ToInt32(txtIndeks.Text)

        If DataModule.TerimaLamaran(idLamaran) Then
            MessageBox.Show("Lamaran Diterima! Data otomatis dimasukkan ke daftar panitia.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilLamaran()
            TampilData()
            UpdateDashboard()
            TampilStatistik()
            txtIndeks.Clear()
            txtAlasan.Clear()
        End If
    End Sub

    Private Sub btnTolak_Click(sender As Object, e As EventArgs) Handles btnTolak.Click
        If txtIndeks.Text = "" Then
            MessageBox.Show("Silakan pilih lamaran yang ingin ditolak pada tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim alasanTolak As String = txtAlasan.Text.Trim()

        If alasanTolak = "" Then
            MessageBox.Show("Harap isi ALASAN mengapa lamaran ditolak pada kolom yang tersedia!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAlasan.Focus()
            Exit Sub
        End If

        Dim idLamaran As Integer = Convert.ToInt32(txtIndeks.Text)
        Dim konfirmasi As DialogResult = MessageBox.Show("Yakin ingin menolak pelamar ini?", "Konfirmasi Tolak", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        UpdateDashboard()

        If konfirmasi = DialogResult.Yes Then
            If DataModule.TolakLamaran(idLamaran, alasanTolak) Then
                MessageBox.Show("Lamaran berhasil ditolak dan alasan telah tersimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilLamaran()
                UpdateDashboard()
                TampilStatistik()
                txtIndeks.Clear()
                txtAlasan.Clear()
            End If
        End If
    End Sub

    Private Sub UpdateDashboard()
        lblPanitia.Text = DataModule.GetTotalPanitia().ToString()
        lblLamaran.Text = DataModule.GetTotalLamaran().ToString()
    End Sub

    Private Sub TampilStatistik()
        Guna2DataGridView2.DataSource = DataModule.GetStatistikDivisi()

        If Guna2DataGridView2.Columns.Count > 0 Then
            Guna2DataGridView2.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Guna2DataGridView2.Columns(1).Width = 150
        End If
    End Sub

    Private Sub ApplyCustomStyle(dgv As Guna.UI2.WinForms.Guna2DataGridView)
        Dim fontTabel As New Font("Malgun Gothic", 14, FontStyle.Bold)
        Dim warnaMerah As Color = Color.FromArgb(172, 0, 0)
        Dim warnaPutih As Color = Color.White

        dgv.EnableHeadersVisualStyles = False

        dgv.ColumnHeadersDefaultCellStyle.BackColor = warnaMerah
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = warnaPutih
        dgv.ColumnHeadersDefaultCellStyle.Font = fontTabel
        dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = warnaMerah
        dgv.ColumnHeadersHeight = 45

        dgv.DefaultCellStyle.BackColor = warnaPutih
        dgv.DefaultCellStyle.ForeColor = warnaMerah
        dgv.DefaultCellStyle.Font = fontTabel

        dgv.DefaultCellStyle.SelectionBackColor = warnaMerah
        dgv.DefaultCellStyle.SelectionForeColor = warnaPutih

        dgv.BackgroundColor = warnaMerah
        dgv.GridColor = warnaPutih
        dgv.RowTemplate.Height = 35
        dgv.BorderStyle = BorderStyle.None
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub
End Class