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
    [Table("uzenetek")]
    public class Uzenet
    {
        [Key]
        public int id { get; set; }
        [Required]
        public  string felado{ get; set; }
        [Required]
        public string cimzett { get; set; }
        [Required]
        public string targy { get; set; }
        [Required]
        public string tartalom { get; set; }
        [Required]
        public DateTime datum { get; set; }
        public Uzenet()
        {

        }
    }

}
