using DataAccessLayer.Concrate;
using EntityLayer.Concrate;
using EntityLayer;
using Elemanlar.net.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrate;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace Elemanlar.net.Controllers
{
    //var authen = HttpContext.AuthenticateAsync();
    //var principal = authen.Result.Principal.Identity.Name;
    //var kullanici = context.Kullanıcılars.FirstOrDefault(x => x.Eposta == principal);
    public class HomeController : Controller
    {
        readonly Context context = new Context();

        DenemeManager denemeManager = new();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Authorize]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Index(Kullanıcılar p)
        {
            Context c = new Context();
            var datavalue= c.Kullanıcılars.FirstOrDefault(x=> x.Eposta == p.Eposta && x.Sifre == p.Sifre);
            if (datavalue != null)
            {
                HttpContext.Session.SetString("username", p.Eposta);
                return RedirectToAction("Denemes", "Home");

            }
            else
            {
                return View();
            }
            
        }

        public IActionResult Privacy()
        {
            return View();
        }



        public IActionResult Ozgecmis()
        {
            return View();
        }

        public IActionResult OzgecmisEkle()
        {
            return View("OzgecmisEkle");
        }


        public IActionResult OzgecmisGoruntule()
        {
            var dd = HttpContext.AuthenticateAsync();
            var ss = dd.Result.Principal.Identity.Name;
            var kullanici = context.Kullanıcılars.FirstOrDefault(x => x.Eposta == ss);
            var id = kullanici.KullaniciId;
            var values = denemeManager.GetOzgecmisGoruntule(id);
            return View(values);
        }

        public IActionResult Denemes()
        {
            var values = denemeManager.GetIsilanlariList();
            return View(values);
        }



        public IActionResult IlaniIncele(int id)
        {
            
            var values = denemeManager.GetById(id);
            return View(values);
            
        }

        public IActionResult FavoriIlanlar()
        {
            var dd = HttpContext.AuthenticateAsync();
            var ss = dd.Result.Principal.Identity.Name;
            var kullanici = context.Kullanıcılars.FirstOrDefault(x => x.Eposta == ss);
            var id = kullanici.KullaniciId;
            var values = denemeManager.GetbyFavoriIlanlarId(id);
            return View(values);

        }


        public IActionResult Basvurular()
        {
            var dd = HttpContext.AuthenticateAsync();
            var ss = dd.Result.Principal.Identity.Name;
            var kullanici = context.Kullanıcılars.FirstOrDefault(x => x.Eposta == ss);
            var id = kullanici.KullaniciId;
            var values = denemeManager.GetbyBasvurularId(id);
            return View(values);

        }



        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="model"></param>




        [HttpPost]
        public void SaveKullanici(Kullanıcılar model)
        {

            context.Kullanıcılars.Add(model);
            context.SaveChanges();

        }      

        [HttpPost]
        public DBResult BasvuruKaydet(Basvurular model)
        {
            
            DBResult result = new DBResult();
            var authen = HttpContext.AuthenticateAsync();
            var principal = authen.Result.Principal.Identity.Name;
            var kullanici = context.Kullanıcılars.FirstOrDefault(x => x.Eposta == principal);
            var basvuruvarmi = context.Basvurulars.FirstOrDefault(x => x.IlanId == model.IlanId && x.KullaniciId == kullanici.KullaniciId);
            if (basvuruvarmi == null)
            {
                model.BasvurmaTarihi = DateTime.Now;
                model.KullaniciId = kullanici.KullaniciId;
                context.Basvurulars.Add(model);
            }
            else
            {
                basvuruvarmi.Status = 0;
                context.Update(basvuruvarmi);

            }
            context.SaveChanges();
            result.COMPLETED = true;
            return result;
        }

        [HttpGet]
        public IActionResult KullaniciAdiGetir()
        {
            DBResult result = new DBResult();
            var authen = HttpContext.AuthenticateAsync();
            var principal = authen.Result.Principal.Identity.Name;
            var kullanici = context.Kullanıcılars.FirstOrDefault(x => x.Eposta == principal);
            return Ok(kullanici);
        }


        [HttpPost]
        [Route("/Home/OzgecmisEkleYeni")]
        public DBResult OzgecmisEkleYeni(Ozgecmisler model)
        {
            DBResult result = new DBResult();
            var authen = HttpContext.AuthenticateAsync();
            var principal = authen.Result.Principal.Identity.Name;
            var kullanici = context.Kullanıcılars.FirstOrDefault(x => x.Eposta == principal);
            model.KullaniciId = kullanici.KullaniciId;
            context.Ozgecmislers.Add(model);
            context.SaveChanges();
            result.COMPLETED = true;
            return result;
        }



        public DBResult BasvurunuGeriCek(Basvurular model)
        {
            DBResult result = new DBResult();
            var authen = HttpContext.AuthenticateAsync();
            var principal = authen.Result.Principal.Identity.Name;
            var kullanici = context.Kullanıcılars.FirstOrDefault(x => x.Eposta == principal);
            var ilan = context.Basvurulars.FirstOrDefault(x => x.IlanId == model.IlanId && x.KullaniciId == kullanici.KullaniciId);
            ilan.Status = 1;
            context.Basvurulars.Update(ilan);
            context.SaveChanges();
            result.COMPLETED = true;
            return result;
        }

        public DBResult FavoriIlanKaldir(FavoriIlanlar model)
        {
            DBResult result = new DBResult();
            var authen = HttpContext.AuthenticateAsync();
            var principal = authen.Result.Principal.Identity.Name;
            var kullanici = context.Kullanıcılars.FirstOrDefault(x => x.Eposta == principal);
            var ilan = context.FavoriIlanlars.FirstOrDefault(x => x.IlanId == model.IlanId && x.KullaniciId == kullanici.KullaniciId);
            ilan.Status = 1;
            context.FavoriIlanlars.Update(ilan);
            context.SaveChanges();
            result.COMPLETED = true;
            return result;
        }


        [HttpPost]
        public DBResult FavoriIlanKaydet(FavoriIlanlar model)
        {
            DBResult result = new DBResult();
            var authen = HttpContext.AuthenticateAsync();
            var principal = authen.Result.Principal.Identity.Name;
            var kullanici = context.Kullanıcılars.FirstOrDefault(x => x.Eposta == principal);
            var favoriilanvarmi = context.FavoriIlanlars.FirstOrDefault(x => x.IlanId == model.IlanId && x.KullaniciId == kullanici.KullaniciId);
            if (favoriilanvarmi == null)
            {
                model.FavoriyeAlmaTarihi = DateTime.Now;
                model.KullaniciId = kullanici.KullaniciId;
                context.FavoriIlanlars.Add(model);
            }
            else
            {
                favoriilanvarmi.Status = 0;
                context.Update(favoriilanvarmi);

            }
            context.SaveChanges();
            result.COMPLETED = true;
            return result;
        }


        [AllowAnonymous]
        public async Task<IActionResult> GirisYap(Kullanıcılar model)
        {
            DBResult result = new DBResult();
            var kullanicigetir = context.Kullanıcılars.FirstOrDefault(x => x.Eposta == model.Eposta && x.Sifre == model.Sifre && x.Status == 0);
            if (kullanicigetir != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, model.Eposta)
                };
                
                var useridentity = new ClaimsIdentity(claims,"Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Denemes","Home");
            }           
            return View();
        }

        

        [HttpPost]
        public DBResult IlaniSikayetEt(IlanSikayetleri model)
        {
            DBResult result = new DBResult();
            var authen = HttpContext.AuthenticateAsync();
            var principal = authen.Result.Principal.Identity.Name;
            var kullanici = context.Kullanıcılars.FirstOrDefault(x => x.Eposta == principal);
            model.KullaniciId = kullanici.KullaniciId;
            model.SikayetEtmeTarihi = DateTime.Now;
            context.IlanSikayetleris.Add(model);
            context.SaveChanges();
            result.COMPLETED = true;
            return result;
        }


        [HttpGet]
        public IActionResult OzgecmisSehirleriGetir()
        {
            DBResult result = new DBResult();
            var sehirler = context.SehirlerVeIlceler.Where(x=> x.UstId == 0).ToList();
            return Ok(sehirler);
        }

        [HttpGet]
        [Route("/Home/IlceleriGetir/{mod}")]
        public IActionResult IlceleriGetir(int mod)
        {
            var ılceler = context.SehirlerVeIlceler.Where(x => x.UstId == mod).ToList();
            return Ok(ılceler);
        }

        

        [HttpGet]
        public IActionResult SektorGetir()
        {           
            var sektorlers = context.Sektorlers.ToList();
            return Ok(sektorlers);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
