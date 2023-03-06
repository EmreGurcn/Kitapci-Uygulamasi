using KitaciUygulamasi.Entities.Concrete;
using KitapciUygulamasi.Core.Interfaces;
using KitapUygulaması.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapciUygulamasi.BLL.EntitiesRepo
{
    public class MusteriAdresRepository : IRepository<MusteriAdres>, IRepositoryForInt<MusteriAdres>
    {
        KitapUygulamasiContext db = new KitapUygulamasiContext();
        public void Ekle(MusteriAdres item)
        {
            db.MusteriAdresler.Add(item);
            db.SaveChanges();
        }

        public List<MusteriAdres> GetByAll()
        {
            return db.MusteriAdresler.ToList();
        }

        public MusteriAdres GetByID(int id)
        {
            if (db.YayinEviAdresler.Find(id) is null)
            {
                throw new NullReferenceException("Aranan değer bulunamadı.");
            }
            return db.MusteriAdresler.Find(id);
        }

        public void Guncelle(MusteriAdres item)
        {
            db.MusteriAdresler.Update(item);
            db.SaveChanges();
        }

        public void Sil(MusteriAdres item)
        {
            db.MusteriAdresler.Remove(item);
            db.SaveChanges();
        }
    }
}
