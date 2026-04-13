Imports MySqlConnector

Module DataModule

    Public Function GetAllPanitia() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT id, nama, alamat, nomorHP, divisi, email " &
                "FROM panitia ORDER BY id ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data panitia: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetPanitiaByID(id As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT id, nama, alamat, nomorHP, divisi, email " &
                "FROM panitia WHERE id = @id"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", id)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchPanitia(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT id, nama, alamat, nomorHP, divisi, email " &
                "FROM panitia " &
                "WHERE nama LIKE @kw OR divisi LIKE @kw OR email LIKE @kw " &
                "ORDER BY id ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SimpanPanitia(nama As String, alamat As String,
                                   nomorHP As String, divisi As String,
                                   email As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO panitia (nama, alamat, nomorHP, divisi, email) " &
                "VALUES (@nama, @alamat, @nomorHP, @divisi, @email)"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@alamat", alamat)
                    cmd.Parameters.AddWithValue("@nomorHP", nomorHP)
                    cmd.Parameters.AddWithValue("@divisi", divisi)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data panitia: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahPanitia(id As Integer, nama As String, alamat As String,
                                 nomorHP As String, divisi As String,
                                 email As String) As Boolean
        Try
            Dim query As String =
                "UPDATE panitia SET " &
                "nama = @nama, alamat = @alamat, nomorHP = @nomorHP, " &
                "divisi = @divisi, email = @email " &
                "WHERE id = @id"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@alamat", alamat)
                    cmd.Parameters.AddWithValue("@nomorHP", nomorHP)
                    cmd.Parameters.AddWithValue("@divisi", divisi)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data panitia: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusPanitia(id As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM panitia WHERE id = @id"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data panitia: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function SimpanLamaran(nama As String, email As String, alamat As String, nomorHP As String, divisi As String, alasan_melamar As String) As Boolean
        Try
            Dim query As String = "INSERT INTO lamaran_panitia (nama, email, alamat, nomorHP, divisi, alasan_melamar, status) VALUES (@nama, @email, @alamat, @nomorHP, @divisi, @alasan, 'Menunggu')"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@alamat", alamat)
                    cmd.Parameters.AddWithValue("@nomorHP", nomorHP)
                    cmd.Parameters.AddWithValue("@divisi", divisi)
                    cmd.Parameters.AddWithValue("@alasan", alasan_melamar)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal mengirim lamaran: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function GetLamaranMenunggu() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT id, nama, email, alamat, nomorHP, divisi, alasan_melamar FROM lamaran_panitia WHERE status = 'Menunggu'"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat daftar lamaran: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function TerimaLamaran(id As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim queryGet As String = "SELECT * FROM lamaran_panitia WHERE id = @id"
                Dim cmdGet As New MySqlCommand(queryGet, conn)
                cmdGet.Parameters.AddWithValue("@id", id)
                Dim reader As MySqlDataReader = cmdGet.ExecuteReader()

                If reader.Read() Then
                    Dim nama = reader("nama").ToString()
                    Dim alamat = reader("alamat").ToString()
                    Dim nomorHP = reader("nomorHP").ToString()
                    Dim divisi = reader("divisi").ToString()
                    Dim email = reader("email").ToString()
                    reader.Close()

                    Dim queryInsert As String = "INSERT INTO panitia (nama, alamat, nomorHP, divisi, email) VALUES (@nama, @alamat, @hp, @div, @email)"
                    Dim cmdInsert As New MySqlCommand(queryInsert, conn)
                    cmdInsert.Parameters.AddWithValue("@nama", nama)
                    cmdInsert.Parameters.AddWithValue("@alamat", alamat)
                    cmdInsert.Parameters.AddWithValue("@hp", nomorHP)
                    cmdInsert.Parameters.AddWithValue("@div", divisi)
                    cmdInsert.Parameters.AddWithValue("@email", email)
                    cmdInsert.ExecuteNonQuery()

                    Dim queryUpdate As String = "UPDATE lamaran_panitia SET status = 'Diterima' WHERE id = @id"
                    Dim cmdUpdate As New MySqlCommand(queryUpdate, conn)
                    cmdUpdate.Parameters.AddWithValue("@id", id)
                    cmdUpdate.ExecuteNonQuery()

                    Return True
                End If
                reader.Close()
            End Using
            Return False
        Catch ex As Exception
            MessageBox.Show("Gagal menerima lamaran: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function TolakLamaran(id As Integer, alasan_ditolak As String) As Boolean
        Try
            Dim query As String = "UPDATE lamaran_panitia SET status = 'Ditolak', alasan_ditolak = @alasan WHERE id = @id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@alasan", alasan_ditolak)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function GetTotalPanitia() As Integer
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM panitia"
                Using cmd As New MySqlCommand(query, conn)
                    Return Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function GetTotalLamaran() As Integer
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM lamaran_panitia WHERE status = 'Menunggu'"
                Using cmd As New MySqlCommand(query, conn)
                    Return Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function GetStatistikDivisi() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT divisi AS 'Nama Divisi', COUNT(*) AS 'Jumlah Personil' " &
                                 "FROM panitia GROUP BY divisi ORDER BY divisi ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat statistik divisi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

End Module