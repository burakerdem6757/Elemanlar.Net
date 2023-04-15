using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Sehirler
    {
        [Key]
        public int SehirId { get; set; }
        public string SehirIsmi { get; set; }
    }
}
