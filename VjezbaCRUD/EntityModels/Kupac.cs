using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VjezbaCRUD.EntityModels
{
    public class Kupac
    {
        [Key]
        public int Id {get; set;}

        public string Naziv { get; set; }

        public string Adresa { get; set; }

        public int PdvBroj { get; set; }

        public string OpstinaPrebivalista { get; set; }
    }
}
