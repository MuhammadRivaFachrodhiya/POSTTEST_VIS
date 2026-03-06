Public Module ModulPerpustakaan
    Public DaftarBuku(99, 1) As String
    Public jumlahBuku As Integer = 0
    Public Sub TambahDataBuku(ByVal jdlBuku As String, ByVal genreBuku As String)
        If jumlahBuku < 100 Then
            DaftarBuku(jumlahBuku, 0) = jdlBuku
            DaftarBuku(jumlahBuku, 1) = genreBuku
            jumlahBuku += 1
        End If
    End Sub
    Public Function CariIndeksBuku(ByVal judulDicari As String) As Integer
        For i As Integer = 0 To jumlahBuku - 1
            If DaftarBuku(i, 0).ToLower() = judulDicari.ToLower() Then
                Return i
            End If
        Next
        Return -1
    End Function
    Public Function HapusDataBuku(ByVal judulDihapus As String) As Boolean
        Dim indeksHapus As Integer = CariIndeksBuku(judulDihapus)
        If indeksHapus >= 0 Then
            For i As Integer = indeksHapus To jumlahBuku - 2
                DaftarBuku(i, 0) = DaftarBuku(i + 1, 0)
                DaftarBuku(i, 1) = DaftarBuku(i + 1, 1)
            Next
            jumlahBuku -= 1
            Return True
        End If
        Return False
    End Function
End Module