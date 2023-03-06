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
    public class YayinEvi : BaseEntity, IEntityID<int>
    {

        public int ID { get; set; }
        public string YayinEviAdi { get; set; }
        public string YetkiliKisi { get; set; }

        //NP
        public List<YayinEviAdres> Adresler { get; set; }
        public List<KitapYayinEvi> Kitaplar { get; set; }
        public List<Telefon> Telefonlar { get; set; }
    }
}
