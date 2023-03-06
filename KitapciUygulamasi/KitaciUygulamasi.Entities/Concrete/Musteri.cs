using KitaciUygulamasi.Entities.Abstracts.AbstractClass;
using KitapciUygulamasi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitaciUygulamasi.Entities.Concrete
{
    public class Musteri : BaseEntity, IEntityID<Guid>
    {
        public Guid ID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }

        //NP
        public List<MusteriAdres> MusteriAdresleri { get; set; }
        public List<Telefon> Telefonlar { get; set; }
        public List<Siparis> Sipariler { get; set; }

        
    }
}
