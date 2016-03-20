using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSQLite
{
    
    public class Operations
    {
            public void CreateDB()
        {
            using (var db = new MyContext())
            {
                db.Database.EnsureCreated();
            }
        }
        public void AddANewNote(Note NewNote)
        {
            using (var db = new MyContext())
            {
                db.Database.EnsureCreated();
                //Note Newnote = new Note();
                //Newnote.Description = "Notes related to panel drawings, OH MY";
                db.Notes.Add(NewNote);
                db.SaveChanges();
            }

        }
    }

   

    //http://www.codeproject.com/Tips/1028801/CodeFirst-with-SQLite-using-Entity-Framework
    public class MyContext : DbContext
    {
        // This property defines the table
        public DbSet<Note> Notes { get; set; }
        public DbSet<NoteCategory> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        // This method connects the context with the database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "ef6NotesManagerV3.sqlite" };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);

            optionsBuilder.UseSqlite(connection);
        }
    }
}

