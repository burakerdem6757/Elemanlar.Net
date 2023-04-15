using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Bolumler
    {
        [Key]
        public int BolumId { get; set; }
        public string BolumIsmi { get; set; }
        public int Status { get; set; }
    }
}
