using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pomelo;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sapi_WareHouse.models
{
    [Table("dolgozok")]
    public class dolgozo
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string fnev { get; set; }
        [Required]
        public string jelszo { get; set; }
        [Required]
        public string teljes_nev { get; set; }
        [Required]
        public string felfuggesztve { get; set; }
        [Required]
        public string admin { get; set; }
        [Required]
        public DateTime szuldat { get; set; }

        public dolgozo()
        {

        }
      
    }
}
