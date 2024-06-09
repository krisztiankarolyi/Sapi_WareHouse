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
    [Table("hianyok")]
    public class hiany
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int cikkszam { get; set; }
        public int termekID { get; set; }
        [Required]
        public string magyarazat { get; set; }
        [Required]
        public int mennyiseg { get; set; }
        [Required]
        public int dolgozo { get; set; }
        [Required]
        public DateTime datum { get; set; }


        public hiany()
        {

        }
    }
}
