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
    public class KargoAdres : BaseEntity, IEntityID<int>, IAdres
    {
        public int ID { get; set; }
        public string Sehir { get; set; }
        public string Ilçe { get; set; }
        public string Mahalle { get; set; }
        public string AdresDetay { get; set; }
        public string PostaKodu { get; set; }
        public int KargoID { get; set; }


        //NP
        public Kargo Kargo { get; set; }



    }
}
