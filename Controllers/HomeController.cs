using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNet_Core.Models;
namespace AspNet_Core.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var ktp = new List<Kitaplar>()
            {
                new Kitaplar(){ID=1,KitapAd="Satranç",Yazar="Zweig"},
                new Kitaplar(){ID=2,KitapAd="Dr Ox'un Deneyi",Yazar="Jules Verne"},
                new Kitaplar(){ID=3,KitapAd="Delifişek",Yazar="Vasconceulos"},
                new Kitaplar(){ID=4,KitapAd="Kırmızı Bisiklet",Yazar="Muzaffer İzgü"},
                new Kitaplar(){ID=5,KitapAd="Toros Canavarı",Yazar="Aziz Nesin"},

            };
            
            return View(ktp);
        }
       
    }
}
