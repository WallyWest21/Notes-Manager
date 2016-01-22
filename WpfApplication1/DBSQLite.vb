Imports System.Data
Imports System.Data.SQLite

Public Class DBSQLite
    Dim ConnectionString As String
    Dim m_dbConnection As SQLiteConnection

    '
    '    Try
    '        SQLiteConnection.CreateFile("Notes Manager.sqlite")
    '    Catch

    '    End Try

    '    m_dbConnection = New SQLiteConnection("Data Source= Notes Manager.sqlite; Version=3;")
    '    m_dbConnection.Open()
    '    Dim strSQL As String
    '    Dim command As SQLiteCommand



    '    Try
    '        strSQL = "CREATE TABLE MainTag (ID int PRIMARY KEY , Designation Varchar(20), TileColor Varchar(20))"
    '        command = New SQLiteCommand(strSQL, m_dbConnection)
    '        command.ExecuteNonQuery()
    '    Catch

    '    End Try

    '    strSQL = "INSERT INTO MainTag (ID, Designation, TileColor) VALUES (NULL, 'Material', 'DarkGoldenRod')"
    '    command = New SQLiteCommand(strSQL, m_dbConnection)
    '    command.ExecuteNonQuery()

    '    Dim adapter As New SQLiteDataAdapter
    '    Dim dataset As New DataSet()

    '    m_dbConnection.Open()

    '    command.CommandText = "SELECT * FROM MainTag"
    '    adapter.SelectCommand = command
    '    adapter.Fill(dataset, "MainTags")

    '    adapter.Dispose()
    '    command.Dispose()
    '    m_dbConnection.Close()

    'End Sub

    Public Function Binding() As DataSet

        'Try
        '    SQLiteConnection.CreateFile("Notes Manager.sqlite")
        'Catch

        'End Try

        m_dbConnection = New SQLiteConnection("Data Source= Notes Manager.sqlite; Version=3;")
        m_dbConnection.Open()
        Dim strSQL As String
        Dim command As SQLiteCommand

        Try
            strSQL = "CREATE TABLE MainTag (ID integer PRIMARY KEY  , Designation Varchar(20), TileColor Varchar(20))"
            command = New SQLiteCommand(strSQL, m_dbConnection)
            command.ExecuteNonQuery()
        Catch

        End Try

        'strSQL = "INSERT INTO MainTag (ID, Designation, TileColor) VALUES (NULL, 'Material', 'DarkGoldenRod')"
        'command = New SQLiteCommand(strSQL, m_dbConnection)
        'command.ExecuteNonQuery()

        'strSQL = "INSERT INTO MainTag (ID, Designation, TileColor) VALUES (NULL, 'SpinPit', 'Crimson')"
        'command = New SQLiteCommand(strSQL, m_dbConnection)
        'command.ExecuteNonQuery()


        Dim adapter As New SQLiteDataAdapter
        Dim dataset As New DataSet()

        'm_dbConnection.Open()

        command = New SQLiteCommand(m_dbConnection)
        command.CommandText = "SELECT * FROM MainTag"
        adapter.SelectCommand = command
        adapter.Fill(dataset, "MainTags")

        'adapter.Dispose()
        'command.Dispose()
        'm_dbConnection.Close()

        'command = New SQLiteCommand(m_dbConnection)
        command.CommandText = "SELECT * FROM Note"
        adapter.SelectCommand = command
        adapter.Fill(dataset, "Notes")

        adapter.Dispose()
        command.Dispose()
        m_dbConnection.Close()

        Return dataset

    End Function
End Class
