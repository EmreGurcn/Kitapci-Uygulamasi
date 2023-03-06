using KitaciUygulamasi.Entities.Abstracts.AbstractClass;
using KitapciUygulamasi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitaciUygulamasi.Entities.Concrete
{
    public class Kargo : BaseEntity, IEntityID<int>
    {

        public int ID { get; set; }
        public string KargoAdi { get; set; }

        //NP
        public List<KargoAdres> KargoAdresler { get; set; }
        public List<Telefon> Telefonlar { get; set; }

        //NP
        public List<Siparis> Siparisler { get; set; }


    }
}
