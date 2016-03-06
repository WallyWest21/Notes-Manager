namespace EFSQL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Note")]
    public partial class Note
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key]
        public int ID { get; set; }

        [StringLength(50)]
        public string Designation { get; set; }

        [StringLength(50)]
        public string TileColor { get; set; }

        [StringLength(10)]
        public string Symbol { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        [StringLength(15)]
        public string VersionNo { get; set; }

        public bool? IsSelected { get; set; }
    }
}
