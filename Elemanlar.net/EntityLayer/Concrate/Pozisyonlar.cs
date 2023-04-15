using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Pozisyonlar
    {
        [Key]
        public int PozisyonId { get; set; }
        public string PozisyonIsmi { get; set; }
        public int Status { get; set; }
    }
}
