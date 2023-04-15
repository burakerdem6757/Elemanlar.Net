using DataAccessLayer.Concrate;
using EntityLayer;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Elemanlar.net.Controllers
{
    public class RegisterController : Controller
    {
        readonly Context context = new Context();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult KayitOl()
        {
            return View();
        }



        [HttpPost]
        public DBResult KayitOl(Kullanıcılar model)
        {
            DBResult result = new DBResult();
            model.HesapOlusturmaTarihi = DateTime.Now;
            context.Kullanıcılars.Add(model);
            context.SaveChanges();
            result.COMPLETED = true;
            return result;
        }


    }
}
