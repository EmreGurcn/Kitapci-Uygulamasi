using KitaciUygulamasi.Entities.Abstracts.AbstractClass;
using KitapciUygulamasi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitaciUygulamasi.Entities.Concrete
{
    public class Yazar : BaseEntity, IEntityID<int>
    {
        public int ID { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }

        //NP

        public List<KitapYazar> Kitaplar { get; set; }

    }
}
