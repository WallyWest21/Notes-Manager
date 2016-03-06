namespace EFSQL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Core;
    using System.Data.Entity.Infrastructure;
    public class Operations
    {

        //public void CreateDB()
        //{

        //    using (var db = new AzureDB())
        //    {
        //        db.Database.EnsureCreated();

        //    }

        //}
        public void AddANewNote()
        {
            using (var db = new AzureDB())
            {
                Note Newnote = new Note();
                Newnote.Designation = "BONded sructure";
                Newnote.Description = "Notes related to panel drawings, OH MY";
                //Newnote.TileColor = "DarkGreen";
                //Newnote.ID = 2;
                Newnote.Symbol = "BS";
                db.Notes.Add(Newnote);


                //try
                //{
                //    db.SaveChanges();
                //}
                //catch (OptimisticConcurrencyException)
                //{
                //    var ctx = ((IObjectContextAdapter)db).ObjectContext;

                //    ctx.Refresh(RefreshMode.ClientWins, db.Notes);
                //    ctx.SaveChanges();
                //}



                db.SaveChanges();
            }

        }




    }





    public partial class AzureDB : DbContext
    {




        public AzureDB()
            : base("name=AzureDB")
        {
        }

        public virtual DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Note>()
            //    .Property(e => e.Symbol)
            //                   .IsFixedLength();


            //modelBuilder.Entity<Note>()
            //    .Property(e => e.Description)
            //    .IsFixedLength();

            //modelBuilder.Entity<Note>()
            //    .Property(e => e.VersionNo)
            //    .IsFixedLength();

            //    modelBuilder.Entity<Note>()
            //       .Property(e => e.ID)
            //       .IsOptional();
            //}
        }
    }
}