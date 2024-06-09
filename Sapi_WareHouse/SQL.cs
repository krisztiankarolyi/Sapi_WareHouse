using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Pomelo;
using MySqlConnector;
using MySql.Data;
using Sapi_WareHouse.models;
using System.Threading.Tasks;


namespace Sapi_WareHouse
{
   public class SQL : DbContext
    {
        public static string ConnString = "server=localhost;port=3306;user=root;password=;database=warehouse";

        private static DbContextOptions MYSQL_DbOptions
        {
            get
            {
                DbContextOptionsBuilder<SQL> dbContextOptionsBuilder = new DbContextOptionsBuilder<SQL>();
                dbContextOptionsBuilder.UseMySql(ConnString,  ServerVersion.AutoDetect(ConnString));
                return dbContextOptionsBuilder.Options;
            }
        }
        public SQL() : base(MYSQL_DbOptions) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

       public DbSet<dolgozo> Dolgozok { get; set; }
       public DbSet<termek> Termekek { get; set; }
       public DbSet<beszallitas> Beszallitasok { get; set; }
       public DbSet<hiany> Hianyok { get; set; }
       public DbSet<Uzenet> Uzenetek { get; set; }
       public DbSet<figyelmeztetes> Figyelmeztetesek { get; set; }
       public DbSet<Eladas> Eladasok { get; set; }


    }
}
