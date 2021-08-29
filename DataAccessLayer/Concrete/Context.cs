using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<AracIslemleri> Arac_Islemleri { get; set; }
        public DbSet<AracTanimlama> Arac_Tanimlama { get; set; }
        public DbSet<BakimOnarim> Bakim_Onarim { get; set; }
        public DbSet<SurucuDetay> Surucu_Detay { get; set; }

    }
}
