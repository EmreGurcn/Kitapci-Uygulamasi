using KitaciUygulamasi.Entities.Abstracts.AbstractClass;
using KitapciUygulamasi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitaciUygulamasi.Entities.Concrete
{
    public class Siparis : BaseEntity, IEntityID<Guid>
    {
        public Guid ID { get; set; }

        public Guid MusteriID { get; set; }
        public int KargoID { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }

        //NP
        public List<SiparisDetayi> Kitaplar { get; set; }

        public Musteri Musteri { get; set; }
        public Kargo Kargo { get; set; }


    }
}
