using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text; 
using Sapi_WareHouse.models;
using System.Threading.Tasks;

namespace Sapi_WareHouse.models
{
    [Table("figyelmeztetesek")]
    public class figyelmeztetes
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int cikkszam { get; set; }
        [Required]

        public string megjegyzes { get; set; }
        public DateTime datum { get; set; }

        public figyelmeztetes()
        {

        }
        public static termek GetTermek(int cikkszam)
        {
            try
            {
                using (SQL sql = new SQL())
                {
                    return sql.Termekek.Where(a => a.cikkszam == cikkszam).Single();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

