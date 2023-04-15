using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    [Table("SehirlerVeIlceler")]
    public  class SehirlerVeIlceler

    {
        [Key]
        public int SehirId { get; set; }
        public int UstId { get; set; }
        public string Sehir { get; set; }
        public string Ilce { get; set; }
    }
}
