using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    [Table("IlanSikayetleri")]
    public class IlanSikayetleri
    {
        [Key]
        public int SikayetId { get; set; }
        public string Sikayet { get; set; }
        public int IlanId { get; set; }
        public int KullaniciId { get; set; }
        public DateTime SikayetEtmeTarihi { get; set; }
        public int Status { get; set; }

    }
}
