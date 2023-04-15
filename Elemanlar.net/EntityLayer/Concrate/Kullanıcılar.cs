using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Kullanıcılar
    {
        [Key]
        public int KullaniciId { get; set; }
        public string AdSoyad { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string Eposta { get; set; }
        public int TelefonNumarasi { get; set; }
        public string Sifre { get; set; }
        public string KullaniciFoto { get; set; }
        public int HesapTuru { get; set; }
        public int Status { get; set; }
        public DateTime? HesapOlusturmaTarihi { get; set; }
        public DateTime? GuncellenmeTarihi { get; set; }
        public DateTime? SilinmeTarihi { get; set; }
    }
}
