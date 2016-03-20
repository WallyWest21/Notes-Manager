using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFSQLite
{
    public class NoteCategory
    {
        [Key]
        public int ID { get; set; }
        public string Designation { get; set; }
        public string Description { get; set; }
        public string VersionNo { get; set; }
        public string stringTileColor { get; set; }
        public string HEXTileColor { get; set; }
    }
}
