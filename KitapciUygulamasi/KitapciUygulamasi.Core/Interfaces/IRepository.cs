using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapciUygulamasi.Core.Interfaces
{
    public interface IRepository<T> 
    {
        void Ekle(T item);
        void Sil(T item);

        void Guncelle(T item);

        List<T> GetByAll();

    }
}
