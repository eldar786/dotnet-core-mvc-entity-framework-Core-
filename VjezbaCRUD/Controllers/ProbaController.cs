using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VjezbaCRUD.Controllers
{
    public class ProbaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public String Ime()
        {
            return "Moje ime je Eldar";
        }

        public IActionResult Unos()
        {
            return View("Views/Home/UnosAB.cshtml");
        }

        public IActionResult Racunaj(int a, int b)
        {
            double s = a + b;
            double o = a - b;
            double m = a * b;

            ViewData["s-kljuc"] = s;
            ViewData["o-kljuc"] = o;
            ViewData["m-kljuc"] = m;

            return View("Views/Home/RacunajView.cshtml");
        }
    }
}