using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.SA
{
     public class User
    {
        [Key]
        [Column(Order=0)]
        public int ID { get; set; }

        public string No { get; set; }

        public string Name { get; set; }
    }
}
