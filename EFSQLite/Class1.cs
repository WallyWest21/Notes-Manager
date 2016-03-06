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
        public void AddANewNote()
        {
            using (var db = new MyContext())
            {
                Note Newnote = new Note();
                Newnote.Designation = "BONded sructure";
                Newnote.Description = "Notes related to panel drawings, OH MY";
                Newnote.Symbol = "BS";
                db.Notes.Add(Newnote);
                db.SaveChanges();
            }

        }





    }

    public class Note
    {
        [Key]
        public int ID { get; set; }
        public string Designation { get; set; }
        public string TileColor { get; set; }
        public string Symbol { get; set; }
        public string Description { get; set; }
        public string VersionNo { get; set; }
        public bool IsSelected { get; set; }
    }

    //http://www.codeproject.com/Tips/1028801/CodeFirst-with-SQLite-using-Entity-Framework
    public class MyContext : DbContext
    {
        // This property defines the table
        public DbSet<Note> Notes { get; set; }

        // This method connects the context with the database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "ef6NotesManagerV2.sqlite" };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);

            optionsBuilder.UseSqlite(connection);
        }
    }
}

