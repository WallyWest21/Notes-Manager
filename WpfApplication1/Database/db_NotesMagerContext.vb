Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration.Conventions

Public Class db_NotesMagerContext
    Inherits DbContext
    Public Property Notes() As DbSet(Of db_Note)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Conventions.Remove(Of PluralizingTableNameConvention)()
    End Sub

    'Protected Overrides Sub OnConfiguring(DbContextOptionsBuilder optionsBuilder)

    '    Dim connectionStringBuilder = New SqliteConnectionStringBuilder { DataSource = "NotesManager.sqlite" };
    '        var connectionString = connectionStringBuilder.ToString();
    '        var connection = New SqliteConnection(connectionString);

    '        optionsBuilder.UseSqlite(connection);
    '    End Sub
End Class
