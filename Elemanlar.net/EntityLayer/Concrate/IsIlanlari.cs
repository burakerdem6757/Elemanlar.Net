using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class IsIlanlari
    {
        [Key]
        public int IlanId { get; set; }
        public string IlanIsmi { get; set; }
        public string IlanIcerigi { get; set; }
        public DateTime YayinlanmaTarihi { get; set; }
        public string IlanImage { get; set; }       
        public int IlanTuru { get; set; }
        public int? FirmaId { get; set; }
        public int Status { get; set; }
        public int PozisyonId { get; set; }
        public DateTime? GuncellenmeTarihi { get; set; }
        public DateTime? SilinmeTarihi { get; set; }


    }
}
