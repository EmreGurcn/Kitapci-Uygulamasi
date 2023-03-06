using KitaciUygulamasi.Entities.Abstracts.AbstractClass;
using KitaciUygulamasi.Entities.Abstracts.Interfaces;
using KitapciUygulamasi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitaciUygulamasi.Entities.Concrete
{
    public class Telefon : BaseEntity, IEntityID<int>, ITelefonNo
    {
        public int ID { get; set; }
        public string TelefonNo { get; set; }
        public int YayinEviID { get; set; }
        public int KargoID { get; set; }

        public Guid MusteriID { get; set; }

        //NP

        public YayinEvi YayinEvi { get; set; }
        public Kargo Kargo { get; set; }
        public Musteri Musteri { get; set; }

    }
}
