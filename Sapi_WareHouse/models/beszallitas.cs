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
    [Table("beszallitasok")]
    public class beszallitas
    {
        [Key]
        public int ID { get; set; }
        public string mertekegyseg { get; set; }
        [Required]
        public int cikkszam { get; set; }
        [Required]
        public string fizetve { get; set; }
        [Required]
        public int egysegar { get; set; }
        [Required]
        public int mennyiseg { get; set; }
        [Required]
        public int afa { get; set; }
        [Required]
        public string SzallitoLevel { get; set; }
        [Required]
        public int atvevo { get; set; }
        [Required]
        public DateTime datum { get; set; }
        public string beszallito { get; set; }
        public string penznem { get; set; }


        public beszallitas()
        {

        }
        public static dolgozo GetDolgozo(int id)
        {
            try
            {
                using (SQL sql = new SQL())
                {
                    return sql.Dolgozok.Where(a => a.ID == id).Single();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }



    }
}
