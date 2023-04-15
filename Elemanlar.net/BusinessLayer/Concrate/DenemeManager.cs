using BusinessLayer.Abstract;
using DataAccessLayer.Concrate;
using EntityLayer;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class DenemeManager : IDenemeService
    {
        Context context = new Context();
        public void BlogAdd(IsIlanlari isilanlari)
        {
            context.Add(isilanlari);
            context.SaveChanges();
        }

        public void BlogRemove(IsIlanlari isilanlari)
        {
            context.Remove(isilanlari);
            context.SaveChanges();
        }

        public void BlogUpdate(IsIlanlari isilanlari)
        {
            context.Update(isilanlari);
            context.SaveChanges();
        }

        public List<IsIlanlari> GetBlogListWithCategory()
        {
            throw new NotImplementedException();
        }

        public List<IsIlanlariViewModel> GetbyBasvurularId(int id)
        {
            var yayinlanmatarihiay = "";
            var ısIlanlaris = new List<IsIlanlariViewModel>();
            var basvurulanilanlar = context.Basvurulars.Where(x => x.KullaniciId == id && x.Status == 0).ToList();
            foreach (var item in basvurulanilanlar)
            {

                var ilan = context.IsIlanlaris.FirstOrDefault(x => x.IlanId == item.IlanId && x.Status == 0);
                var firma = context.Firmalars.FirstOrDefault(x => x.FirmaId == ilan.FirmaId);
                if (ilan.YayinlanmaTarihi.Month == 1)
                {
                    yayinlanmatarihiay = "OCK";
                }
                if (ilan.YayinlanmaTarihi.Month == 2)
                {
                    yayinlanmatarihiay = "ŞUB";
                }
                if (ilan.YayinlanmaTarihi.Month == 3)
                {
                    yayinlanmatarihiay = "MAR";
                }
                if (ilan.YayinlanmaTarihi.Month == 4)
                {
                    yayinlanmatarihiay = "NİS";
                }
                if (ilan.YayinlanmaTarihi.Month == 5)
                {
                    yayinlanmatarihiay = "MAY";
                }
                if (ilan.YayinlanmaTarihi.Month == 6)
                {
                    yayinlanmatarihiay = "HAZ";
                }
                if (ilan.YayinlanmaTarihi.Month == 7)
                {
                    yayinlanmatarihiay = "TEM";
                }
                if (ilan.YayinlanmaTarihi.Month == 8)
                {
                    yayinlanmatarihiay = "AĞU";
                }
                if (ilan.YayinlanmaTarihi.Month == 9)
                {
                    yayinlanmatarihiay = "EYL";
                }
                if (ilan.YayinlanmaTarihi.Month == 10)
                {
                    yayinlanmatarihiay = "EKİ";
                }
                if (ilan.YayinlanmaTarihi.Month == 11)
                {
                    yayinlanmatarihiay = "KAS";
                }
                if (ilan.YayinlanmaTarihi.Month == 12)
                {
                    yayinlanmatarihiay = "ARA";
                }
                var model = new IsIlanlariViewModel()
                {
                    IlanId = ilan.IlanId,
                    IlanIsmi = ilan.IlanIsmi,
                    IlanIcerigi = ilan.IlanIcerigi,
                    FirmaIsmi = firma.FirmaIsmi,
                    FirmaHakkında = firma.FirmaHakkinda,
                    FirmaFoto = firma.FirmaFoto,
                    YayınlanmaTarihi = ilan.YayinlanmaTarihi,
                    YayınlanmaTarihiAy = yayinlanmatarihiay,

                };
                ısIlanlaris.Add(model);
            }
            return ısIlanlaris;
        }

        public OzgecmisViewModel GetOzgecmisGoruntule(int id)
        {
            var ozgecmis = context.Ozgecmislers.FirstOrDefault(x=> x.KullaniciId == id);
            var yas = DateTime.Now.Year - ozgecmis.DogumTarihi.Value.Year;
            var sehir = context.SehirlerVeIlceler.FirstOrDefault(x => x.SehirId == ozgecmis.SehirId);
            var ilce = context.SehirlerVeIlceler.FirstOrDefault(x => x.SehirId == ozgecmis.IlceId);
            var sektor = context.Sektorlers.FirstOrDefault(x => x.SektorId == ozgecmis.IsDeneyimiFirmaSektoruId);
            var isdeneyimisehir = context.SehirlerVeIlceler.FirstOrDefault(x => x.SehirId == ozgecmis.IsDeneyimiSehirId);
            var cinsiyet = "";
            var ehliyet = "";
            var askerlikdurumu = "";
            var egitimdevamdurumu = "";
            var isdeneyimicalismadurumu = "";
            var isdeneyimicalısmasekli = "";
            var yabancidil = "";
            if (ozgecmis.CinsiyetId == 1)
            {
                cinsiyet = "Erkek";
            }
            else
            {
                cinsiyet = "Kadın";
            }


            if (ozgecmis.EhliyetId == 1)
            {
                cinsiyet = "Var";
            }
            else
            {
                cinsiyet = "Yok";
            }


            if (ozgecmis.AskerlikDurumuId == 1)
            {
                askerlikdurumu = "Yapıldı";
            }
            if (ozgecmis.AskerlikDurumuId == 2)
            {
                askerlikdurumu = "Tecilli";
            }
            if (ozgecmis.AskerlikDurumuId == 3)
            {
                askerlikdurumu = "Muaf";
            }

            if (ozgecmis.DevamDurumuId == 1)
            {
                egitimdevamdurumu = "Devam Ediyor";
            }
            if (ozgecmis.DevamDurumuId == 2)
            {
                egitimdevamdurumu = "Mezun";
            }
            if (ozgecmis.DevamDurumuId == 3)
            {
                egitimdevamdurumu = "Terk";
            }


            if (ozgecmis.IsDeneyimiCalismaDurumuId == 1)
            {
                isdeneyimicalismadurumu = "Çalışıyor";
            }
            else
            {
                isdeneyimicalismadurumu = "Çalışmıyor";
            }

            if (ozgecmis.IsDeneyimiCalismaSekliId == 1)
            {
                isdeneyimicalısmasekli = "Tam Zamanlı";
            }
            if (ozgecmis.IsDeneyimiCalismaSekliId == 2)
            {
                isdeneyimicalısmasekli = "Part-Time";
            }

            if (ozgecmis.IsDeneyimiCalismaSekliId == 3)
            {
                isdeneyimicalısmasekli = "Uzaktan";
            }


            if (ozgecmis.YabanciDilId == 1)
            {
                yabancidil = "İngilizce";
            }
            if (ozgecmis.YabanciDilId == 2)
            {
                yabancidil = "Almanca";
            }
            if (ozgecmis.YabanciDilId == 3)
            {
                yabancidil = "İtalyanca";
            }
            if (ozgecmis.YabanciDilId == 4)
            {
                yabancidil = "Fransızca";
            }
            var model = new OzgecmisViewModel()
            {
                Ad = ozgecmis.Ad,
                Soyad = ozgecmis.Soyad,
                Unvan = ozgecmis.Unvan,
                Eposta = ozgecmis.Eposta,
                Yas = yas,
                WebSayfasi = ozgecmis.WebSayfasi,
                Sehir = sehir.Sehir,
                Ilce = ilce.Ilce,
                Telefon = ozgecmis.Telefon,
                OzetBilgi = ozgecmis.OzetBilgi,
                Cinsiyet = cinsiyet,
                Ehliyet = ehliyet,
                AskerlikDurumu = askerlikdurumu,
                MaasBeklentisi = ozgecmis.MaasBeklentisi,
                ReferansAdiSoyadi = ozgecmis.ReferansAdiSoyadi,
                ReferansEmail = ozgecmis.ReferansEmail,
                ReferansTelefon = ozgecmis.ReferansTelefon,
                ReferansUnvan = ozgecmis.ReferansUnvan,
                ReferansCalistigiFirmaninIsmi = ozgecmis.ReferansCalistigiFirmaninIsmi,
                ReferansCalistigiPozisyon = ozgecmis.ReferansCalistigiPozisyon,
                Hobiler = ozgecmis.Hobiler,
                EgitimDurumu = ozgecmis.EgitimDurumu,
                EgitimBaslangicTarihi = ozgecmis.EgitimBaslangicTarihi,
                EgitimBitisTarihi = ozgecmis.EgitimBitisTarihi,
                DevamDurumu = egitimdevamdurumu,
                DiplomaNotu = ozgecmis.DiplomaNotu,
                IsDeneyimiFirmaAdi = ozgecmis.IsDeneyimiFirmaAdi,
                IsDeneyimiPozisyon = ozgecmis.IsDeneyimiPozisyon,
                IsDeneyimiBaslangicTarihi = ozgecmis.IsDeneyimiBaslangicTarihi,
                IsDeneyimiBitisTarihi = ozgecmis.IsDeneyimiBitisTarihi,
                IsDeneyimiCalismaDurumu = isdeneyimicalismadurumu,
                IsDeneyimiFirmaSektoru = sektor.Sektor,
                IsDeneyimiCalismaSekli = isdeneyimicalısmasekli,
                IsDeneyimiSehir = isdeneyimisehir.Sehir,
                IsDeneyimiIsTanimi = ozgecmis.IsDeneyimiIsTanimi,
                YabanciDil = yabancidil,
                YabanciDilSeviye = ozgecmis.YabanciDilSeviye,
                SertifikaAdi = ozgecmis.SertifikaAdi,
                AlindigiKurum = ozgecmis.AlindigiKurum,
                SertifikaTarihi = ozgecmis.SertifikaTarihi,
                BilgisayarProgrami = ozgecmis.BilgisayarProgrami,
                Yetenek = ozgecmis.Yetenek,
                ProfilFotografi = ozgecmis.ProfilFotografi,
                Status = ozgecmis.Status,
            };
            return model;
        }

        public List <IsIlanlariViewModel> GetbyFavoriIlanlarId(int id)
        {
            var yayinlanmatarihiay = "";
            var ısIlanlaris = new List<IsIlanlariViewModel>();
            var favoriilanlar = context.FavoriIlanlars.Where(x=> x.KullaniciId == id && x.Status == 0).ToList();
            foreach (var item in favoriilanlar)
            {
                
                var ilan = context.IsIlanlaris.FirstOrDefault(x => x.IlanId == item.IlanId && x.Status == 0);
                var firma = context.Firmalars.FirstOrDefault(x => x.FirmaId == ilan.FirmaId);
                if (ilan.YayinlanmaTarihi.Month == 1)
                {
                    yayinlanmatarihiay = "OCK";
                }
                if (ilan.YayinlanmaTarihi.Month == 2)
                {
                    yayinlanmatarihiay = "ŞUB";
                }
                if (ilan.YayinlanmaTarihi.Month == 3)
                {
                    yayinlanmatarihiay = "MAR";
                }
                if (ilan.YayinlanmaTarihi.Month == 4)
                {
                    yayinlanmatarihiay = "NİS";
                }
                if (ilan.YayinlanmaTarihi.Month == 5)
                {
                    yayinlanmatarihiay = "MAY";
                }
                if (ilan.YayinlanmaTarihi.Month == 6)
                {
                    yayinlanmatarihiay = "HAZ";
                }
                if (ilan.YayinlanmaTarihi.Month == 7)
                {
                    yayinlanmatarihiay = "TEM";
                }
                if (ilan.YayinlanmaTarihi.Month == 8)
                {
                    yayinlanmatarihiay = "AĞU";
                }
                if (ilan.YayinlanmaTarihi.Month == 9)
                {
                    yayinlanmatarihiay = "EYL";
                }
                if (ilan.YayinlanmaTarihi.Month == 10)
                {
                    yayinlanmatarihiay = "EKİ";
                }
                if (ilan.YayinlanmaTarihi.Month == 11)
                {
                    yayinlanmatarihiay = "KAS";
                }
                if (ilan.YayinlanmaTarihi.Month == 12)
                {
                    yayinlanmatarihiay = "ARA";
                }
                var model = new IsIlanlariViewModel()
                {
                    IlanId = ilan.IlanId,
                    IlanIsmi = ilan.IlanIsmi,
                    IlanIcerigi = ilan.IlanIcerigi,
                    FirmaIsmi = firma.FirmaIsmi,
                    FirmaHakkında = firma.FirmaHakkinda,
                    FirmaFoto = firma.FirmaFoto,
                    YayınlanmaTarihi = ilan.YayinlanmaTarihi,
                    YayınlanmaTarihiAy = yayinlanmatarihiay,

                };
                ısIlanlaris.Add(model);
            }
            return ısIlanlaris;
        }

        public IsIlanlariViewModel GetById(int id)
        {
            var isilani = context.IsIlanlaris.FirstOrDefault(x=> x.IlanId == id);
            var firma = context.Firmalars.FirstOrDefault(x=> x.FirmaId == isilani.FirmaId);
            var kullanicibasvuru = context.Basvurulars.FirstOrDefault(x => x.IlanId == isilani.IlanId && x.KullaniciId == 1);
            var kullanicifavoriilan = context.FavoriIlanlars.FirstOrDefault(x => x.IlanId == id);
            
            IsIlanlariViewModel model = new IsIlanlariViewModel();
            {
                model.IlanId = isilani.IlanId;
                model.IlanIsmi = isilani.IlanIsmi;
                model.IlanIcerigi = isilani.IlanIcerigi;
                model.FirmaIsmi =  firma.FirmaIsmi;
                model.FirmaHakkında = firma.FirmaHakkinda;
                model.FirmaFoto = firma.FirmaFoto;
                if (kullanicibasvuru == null)
                {
                    model.BasvurulmusIlanStatus = 1;
                }
                else
                {
                    model.BasvurulmusIlanStatus = kullanicibasvuru.Status;
                }
                if (kullanicifavoriilan == null)
                {
                    model.FavoriIlanStatus = 1;
                }
                else
                {
                        model.FavoriIlanStatus = kullanicifavoriilan.Status;
                }
            }
            return model;
        }

        public List<IsIlanlari> GetList()
        {
            return context.IsIlanlaris.ToList();
        }

        public List<IsIlanlariViewModel> GetIsilanlariList()
        {
            List<IsIlanlariViewModel> isilanlarilist = new List<IsIlanlariViewModel>();
            var isilanlari = context.IsIlanlaris.ToList();
            
            foreach (var item in isilanlari)
            {
                var yayinlanmatarihiay = "";
                var firma = context.Firmalars.Where(x=> x.FirmaId == item.FirmaId).FirstOrDefault();
                if (item.YayinlanmaTarihi.Month == 1)
                {
                    yayinlanmatarihiay = "OCK";
                }
                if (item.YayinlanmaTarihi.Month == 2)
                {
                    yayinlanmatarihiay = "ŞUB";
                }
                if (item.YayinlanmaTarihi.Month == 3)
                {
                    yayinlanmatarihiay = "MAR";
                }
                if (item.YayinlanmaTarihi.Month == 4)
                {
                    yayinlanmatarihiay = "NİS";
                }
                if (item.YayinlanmaTarihi.Month == 5)
                {
                    yayinlanmatarihiay = "MAY";
                }
                if (item.YayinlanmaTarihi.Month == 6)
                {
                    yayinlanmatarihiay = "HAZ";
                }
                if (item.YayinlanmaTarihi.Month == 7)
                {
                    yayinlanmatarihiay = "TEM";
                }
                if (item.YayinlanmaTarihi.Month == 8)
                {
                    yayinlanmatarihiay = "AĞU";
                }
                if (item.YayinlanmaTarihi.Month == 9)
                {
                    yayinlanmatarihiay = "EYL";
                }
                if (item.YayinlanmaTarihi.Month == 10)
                {
                    yayinlanmatarihiay = "EKİ";
                }
                if (item.YayinlanmaTarihi.Month == 11)
                {
                    yayinlanmatarihiay = "KAS";
                }
                if (item.YayinlanmaTarihi.Month == 12)
                {
                    yayinlanmatarihiay = "ARA";
                }
                IsIlanlariViewModel ısIlanlariViewModel = new IsIlanlariViewModel
                {
                    IlanId = item.IlanId,
                    IlanIsmi = item.IlanIsmi,
                    IlanIcerigi = item.IlanIcerigi,
                    FirmaIsmi = firma.FirmaIsmi,
                    FirmaHakkında = firma.FirmaHakkinda,
                    FirmaFoto = firma.FirmaFoto,
                    YayınlanmaTarihi = item.YayinlanmaTarihi,
                    YayınlanmaTarihiAy = yayinlanmatarihiay,
                       
                };
                isilanlarilist.Add(ısIlanlariViewModel);

            }
            return isilanlarilist;
        }

    }
}

