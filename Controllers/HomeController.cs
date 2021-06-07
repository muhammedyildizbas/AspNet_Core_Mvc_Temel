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
            return View();
        }
        public IActionResult Index1()
        {
            var ktp = new List<Kitap>()
           {
               new Kitap(){ID=1,KitapAd="80 Günde Devri Alem",Yazar="Jules Verne"},
               new Kitap(){ID=2,KitapAd="Bilinmeyen Bir Kadının Mektubu",Yazar="Zweig"},
           };

            return View(ktp);
        }
        
      
    }
}
