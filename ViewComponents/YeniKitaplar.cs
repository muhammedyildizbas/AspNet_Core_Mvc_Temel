using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNet_Core.Models;

namespace AspNet_Core.ViewComponents
{
    public class YeniKitaplar: ViewComponent
    {

        public IViewComponentResult Invoke()
    {
            var kitaplistesi = new List<Kitaplar>
            {
               new Kitaplar
               {
                   ID=6,
                   KitapAd="Korku",
                   Yazar="Zweig"
               },
                new Kitaplar
               {
                   ID=7,
                   KitapAd="Anna Karanina",
                   Yazar="Tolstoy"
               }

            };
            return View(kitaplistesi);
    }
    }
}
