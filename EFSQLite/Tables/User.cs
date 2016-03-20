using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFSQLite
{
   public class User
    {
        [Key]
        public int ID { get; set; }
      
    }
}
