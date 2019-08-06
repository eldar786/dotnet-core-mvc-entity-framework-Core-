using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VjezbaCRUD.EF;
using VjezbaCRUD.EntityModels;
using VjezbaCRUD.ViewModels;

namespace VjezbaCRUD.Controllers
{
    public class KupacController : Controller
    {
        public IActionResult Prikazi()
        {
            MyContext db = new MyContext();
            List<KupacPrikaziViewModel> podaci = db.Kupac
                .Select(k => new KupacPrikaziViewModel
                {
                    Naziv = k.Naziv,
                    id = k.Id,
                    PdvBroj = k.PdvBroj,
                    Adresa = k.Adresa,
                    OpstinaPrebivalista = k.OpstinaPrebivalista,
                    BrojFaktura = db.Faktura.Where(q=>q.Id == k.Id).Count(),
                    SumaFaktura = db.Faktura.Where(q=>q.Id == k.Id).Sum(s=>(double?) s.Iznos),
                })
            .ToList();


            ViewData["podaci-kljuc"] = podaci;
            return View();
        }
        public IActionResult Obrisi(int id)
        {
            MyContext db = new MyContext();
            Kupac k = db.Kupac.Find(id);
            if (k==null)
            {
                return Content("Kupac ne postoji");
            }
            else
            {
                db.Remove(k);

                db.SaveChanges();
                return Redirect("/Kupac/Prikazi");

            }
        }
    }
}