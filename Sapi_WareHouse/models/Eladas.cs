using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pomelo;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sapi_WareHouse.models
{
    [Table("Eladasok")]
    public class Eladas
    {
        [Key]
        public int ID { get; set; }
        public int ertek { get; set; }
        public int cikkszam { get; set; }
        public string megnevezes { get; set; }
        public int mennyiseg { get;  set; }
        public string szamlaszam { get; set; }
        public DateTime datum { get; set; }

        public Eladas()
        {
                
        }
    }


}
