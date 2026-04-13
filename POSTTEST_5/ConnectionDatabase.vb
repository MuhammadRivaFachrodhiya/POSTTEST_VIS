Imports MySqlConnector
Module ConnectionDatabase
    Public ReadOnly ConnectionString As String =
    "Server=localhost;Port=3306;Database=projectmplid;UserID=root;Password=;"
    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function
End Module