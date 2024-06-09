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
    [Table("termekek")]
    public class termek
    {
        [Key]
        public int ID { get; set; }
        public int cikkszam { get; set; }
        [Required]
        public string megnevezes { get; set; }
        public string kategoria { get; set; }
        public int jelenleg_keszlet { get; set; }
        public string leltariv { get; set; }
        public string mertekegyseg { get; set; }
        public int elozo_ho_keszlet { get; set; }
        public int afa_kulcs { get; set; }
        public int netto_ertek { get; set; }
        public int brutto_ertek { get; set; }
        public int br_beszerzesi_ertek { get; set; }
        public string penznem { get; set; }
        public DateTime szavatossag { get; set; }
        public termek()
        {

        }



    }
    }
