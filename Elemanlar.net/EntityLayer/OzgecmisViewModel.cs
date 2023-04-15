using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class OzgecmisViewModel
    {
        public int OzgecmisId { get; set; }
        public int KullaniciId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Unvan { get; set; }
        public string Eposta { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public int Yas { get; set; }

        public string WebSayfasi { get; set; }
        public string Sehir { get; set; }
        public string Ilce { get; set; }
        public string Telefon { get; set; }
        public string OzetBilgi { get; set; }
        public string Cinsiyet { get; set; }
        public string Ehliyet { get; set; }
        public string AskerlikDurumu { get; set; }
        public string MaasBeklentisi { get; set; }
        public string ReferansAdiSoyadi { get; set; }
        public string ReferansEmail { get; set; }
        public string ReferansTelefon { get; set; }
        public string ReferansUnvan { get; set; }
        public string ReferansCalistigiFirmaninIsmi { get; set; }
        public string ReferansCalistigiPozisyon { get; set; }
        public string Hobiler { get; set; }
        public string EgitimDurumu { get; set; }
        public DateTime? EgitimBaslangicTarihi { get; set; }
        public DateTime? EgitimBitisTarihi { get; set; }
        public string DevamDurumu { get; set; }
        public int DiplomaNotu { get; set; }
        public string IsDeneyimiFirmaAdi { get; set; }
        public string IsDeneyimiPozisyon { get; set; }
        public DateTime? IsDeneyimiBaslangicTarihi { get; set; }
        public DateTime? IsDeneyimiBitisTarihi { get; set; }
        public string IsDeneyimiCalismaDurumu { get; set; }
        public string IsDeneyimiFirmaSektoru { get; set; }
        public string IsDeneyimiCalismaSekli { get; set; }
        public string IsDeneyimiSehir { get; set; }
        public string IsDeneyimiIsTanimi { get; set; }
        public string YabanciDil { get; set; }
        public string YabanciDilSeviye { get; set; }
        public string SertifikaAdi { get; set; }
        public string AlindigiKurum { get; set; }
        public DateTime? SertifikaTarihi { get; set; }
        public string BilgisayarProgrami { get; set; }
        public string Yetenek { get; set; }
        public string ProfilFotografi { get; set; }
        public int Status { get; set; }
    }
}
