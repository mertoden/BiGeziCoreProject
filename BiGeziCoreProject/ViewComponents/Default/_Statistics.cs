using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiGeziCoreProject.ViewComponents.Default
{
    public class _Statistics: ViewComponent
    {
         public IViewComponentResult Invoke()
         {
            using var c = new Context();
            ViewBag.Rota = c.Destinations.Count();
            ViewBag.Rehber = c.Guides.Count();
            ViewBag.Musteri = "285";
            return View();
         }
    }
}
