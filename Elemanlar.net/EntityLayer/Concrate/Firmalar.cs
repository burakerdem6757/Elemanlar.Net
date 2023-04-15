using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Firmalar
    {
        [Key]
        public int FirmaId { get; set; }
        public string FirmaIsmi{ get; set; }
        public string FirmaHakkinda { get; set; }
        public string FirmaFoto { get; set; }
        public int Status { get;set; }
    }
}
