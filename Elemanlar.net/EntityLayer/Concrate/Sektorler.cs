using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    [Table("Sektorler")]
    public class Sektorler
    {
        [Key]
        public int SektorId { get; set; }
        public string Sektor { get; set; }
    }
}
