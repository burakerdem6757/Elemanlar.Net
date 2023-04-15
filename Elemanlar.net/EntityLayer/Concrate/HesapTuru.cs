using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class HesapTuru
    {
        [Key]
        public int HesapId { get; set; }
        public string HesapTuruIsmi { get; set; }
    }
}
