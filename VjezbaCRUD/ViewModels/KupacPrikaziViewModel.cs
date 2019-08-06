using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VjezbaCRUD.ViewModels
{
    public class KupacPrikaziViewModel
    {
        public string Naziv { get; set; }

        public string Adresa { get; set; }

        public int PdvBroj { get; set; }

        public string OpstinaPrebivalista{ get; set; }

        public int id { get; set; }

        public int BrojFaktura { get; set; }

        public double? SumaFaktura { get; set; }

    }
}
