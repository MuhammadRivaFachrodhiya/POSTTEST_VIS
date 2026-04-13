Module ValidationModule

    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse
           Char.IsWhiteSpace(e.KeyChar) OrElse
           Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngkaHP(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse
           Char.IsControl(e.KeyChar) OrElse
           e.KeyChar = "+"c Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = ChrW(13)
    End Function

    Public Function ValidasiTextBox(ep As ErrorProvider,
                                    txt As Control,
                                    pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider,
                                     cb As ComboBox,
                                     pesan As String) As Boolean
        If cb.SelectedIndex = -1 Then
            ep.SetError(cb, pesan)
            Return False
        Else
            ep.SetError(cb, "")
            Return True
        End If
    End Function

    Public Function ValidasiDataPanitia(ep As ErrorProvider,
                                         txtNama As Control,
                                         txtAlamat As Control,
                                         txtNomorHP As Control,
                                         cbDivisi As ComboBox,
                                         txtEmail As Control) As Boolean
        Dim namaValid As Boolean =
            ValidasiTextBox(ep, txtNama, "Nama tidak boleh kosong!")

        Dim alamatValid As Boolean =
            ValidasiTextBox(ep, txtAlamat, "Alamat tidak boleh kosong!")

        Dim hpValid As Boolean =
            ValidasiTextBox(ep, txtNomorHP, "Nomor HP tidak boleh kosong!")

        Dim divisiValid As Boolean =
            ValidasiComboBox(ep, cbDivisi, "Silakan pilih Divisi!")

        Dim emailValid As Boolean =
            ValidasiTextBox(ep, txtEmail, "Email tidak boleh kosong!")

        Return namaValid And alamatValid And hpValid And divisiValid And emailValid
    End Function

    Public Function IsEmailValid(email As String) As Boolean
        Return email.Contains("@") AndAlso email.Contains(".")
    End Function

End Module