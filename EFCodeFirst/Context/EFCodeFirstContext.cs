using EFCodeFirst.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.Context
{
    public  class EFCodeFirstContext:DbContext
    {

        public EFCodeFirstContext():base ("Server=DESKTOP-JI1JKUA\\SQLEXPRESS;Database=EFCodeFirstDB;Trusted_Connection=true")
        {
            
        }




        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Sinif> Siniflar { get; set; }

    }
}
