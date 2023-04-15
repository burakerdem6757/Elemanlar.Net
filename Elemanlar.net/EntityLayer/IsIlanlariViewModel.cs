using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class IsIlanlariViewModel
    {
        public int IlanId { get; set; }
        public string IlanIsmi { get; set; }
        public string IlanIcerigi { get; set; }

        public DateTime YayınlanmaTarihi { get; set; }
        public string YayınlanmaTarihiAy { get; set; }
        public string FirmaIsmi { get; set; }
        public string FirmaHakkında { get; set; }      
        public string FirmaFoto { get; set; }
        public int FavoriIlanStatus { get; set; }
        public int BasvurulmusIlanStatus { get; set; }
    }
}
