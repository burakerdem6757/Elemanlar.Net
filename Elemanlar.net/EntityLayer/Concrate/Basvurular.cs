using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    [Table("Basvurular")]
    public class Basvurular
    {
        [Key]
        public int BasvuruId { get; set; }
        public string IlanBaslik { get; set; }

        public int IlanId { get; set; }
        public int KullaniciId { get; set; }
        public DateTime BasvurmaTarihi { get; set; }
        public int Status { get; set; }
    }
}
