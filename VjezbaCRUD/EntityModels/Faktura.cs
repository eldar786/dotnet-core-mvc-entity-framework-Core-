using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VjezbaCRUD.EntityModels
{
    public class Faktura
    {
        [Key]
        public int Id { get; set; }

        public DateTime Datum { get; set; }

        public int KId { get; set; }
        [ForeignKey("KId")]

        public Kupac Kupac { get; set; }

        public double Iznos { get; set; }
    }
}
