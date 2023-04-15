using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Ozgecmis
    {
        [Key]
        public int OzgecmisId { get; set; }
        public string KullaniciId { get; set; }
        public string AdSoyad { get; set; }
        public string Cinsiyet { get; set; }
        public string Eposta { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Adres { get; set; }
        public int TelefonNumarası { get; set; }

        public int AskerlikDurumu { get; set; }

        public string SurucuBelgesi { get; set; }

        public string Aciklama { get; set; }
        public int EgitimSeviyesi { get; set; }

        public int UniversiteBolumu { get; set; }

        public string Universite { get; set; }



    }
}
