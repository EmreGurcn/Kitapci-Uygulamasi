using KitaciUygulamasi.Entities.Abstracts.AbstractClass;
using KitaciUygulamasi.Entities.Concrete;
using KitapciUygulamasi.Mapping.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KitapUygulaması.DataAccess
{
    public class KitapUygulamasiContext:DbContext
    {
        public DbSet<YayinEviAdres> YayinEviAdresler { get; set; }
        public DbSet<KargoAdres> KargoAdresler { get; set; }
        public DbSet<MusteriAdres> MusteriAdresler { get; set; }
        public DbSet<Kargo> Kargolar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<Telefon> Telefonlar { get; set; }
        public DbSet<YayinEvi> YayinEvleri { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=KitapciUygulamasi;uid=sa;pwd=123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new KitapKategoriMapping());
            modelBuilder.ApplyConfiguration(new KitapYayinEviMapping());
            modelBuilder.ApplyConfiguration(new KitapYazarMapping());
            modelBuilder.ApplyConfiguration(new SiparisDetaylariMapping());

            //modelBuilder.Entity<BaseEntity>().Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);

            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }

    
}
