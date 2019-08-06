using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VjezbaCRUD.EntityModels
{
    public class Proizvod
    {
        [Key]
        public int id { get; set; }
    }
}
