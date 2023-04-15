using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-LA7M594\\SQLEXPRESS;database=Elemanlarnet; integrated security= true;");
        }
        public DbSet<Bolumler> Bolumlers { get; set; }
        public DbSet<CalismaSekli> CalismaSeklis { get; set; }
        public DbSet<EgitimSeviyesi> EgitimSeviyesis { get; set; }
        public DbSet<Firmalar> Firmalars { get; set; }
        public DbSet<HesapTuru> HesapTurus { get; set; }

        public DbSet<SehirlerVeIlceler> SehirlerVeIlceler { get; set; }

        public DbSet<Sektorler> Sektorlers { get; set; }
        public DbSet<IlanSikayetleri> IlanSikayetleris { get; set; }
        public DbSet<FavoriIlanlar> FavoriIlanlars { get; set; }
        public DbSet<Basvurular> Basvurulars { get; set; }
        public DbSet<IlanTuru> IlanTurus { get; set; }
        public DbSet<IsIlanlari> IsIlanlaris { get; set; }
        public DbSet<Kullanıcılar> Kullanıcılars { get; set; }
        public DbSet<Ozgecmis> Ozgecmiss { get; set; }

        public DbSet<Ozgecmisler> Ozgecmislers { get; set; }
        public DbSet<Pozisyonlar> Pozisyonlars { get; set; }
        public DbSet<Sehirler> Sehirlers { get; set; }
        public DbSet<UniversiteBolumu> UniversiteBolumus { get; set; }

    }
}
