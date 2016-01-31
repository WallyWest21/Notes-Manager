Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration.Conventions

Public Class db_NotesMagerContext
    Inherits DbContext
    Public Property Notes() As DbSet(Of db_Note)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Conventions.Remove(Of PluralizingTableNameConvention)()
    End Sub
End Class
