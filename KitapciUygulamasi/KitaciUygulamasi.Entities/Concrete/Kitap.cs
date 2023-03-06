using KitaciUygulamasi.Entities.Abstracts.AbstractClass;
using KitapciUygulamasi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitaciUygulamasi.Entities.Concrete
{
    public class Kitap : BaseEntity, IEntityID<int>
    {
        public int ID { get; set; }
        public string KitapAdi { get; set; }
        public decimal Fiyat { get; set; }
        public int SayfaSayisi { get; set; }
        public DateTime BasimYili { get; set; }

        //NP

        public List<KitapKategori> Kategoriler { get; set; }

        public List<KitapYazar> Yazarlar { get; set; }

        public List<KitapYayinEvi> YayinEvileri { get; set; }
        public List<SiparisDetayi> Siparisler { get; set; }



    }
}
