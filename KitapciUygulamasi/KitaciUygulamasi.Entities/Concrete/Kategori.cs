using KitaciUygulamasi.Entities.Abstracts.AbstractClass;
using KitapciUygulamasi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitaciUygulamasi.Entities.Concrete
{
    public class Kategori : BaseEntity, IEntityID<int>
    {
        public int ID { get; set; }
        public string KategoriAdi { get; set; }

        //NP
        public List<KitapKategori> Kitaplar { get; set; }

    }
}
