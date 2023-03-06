using KitaciUygulamasi.Entities.Abstracts.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitaciUygulamasi.Entities.Concrete
{
    public class SiparisDetayi:BaseEntity
    {
        public Guid SiparisID { get; set; }
        public int KitapID { get; set; }
        public byte Adet { get; set; }
        public float IndirimOrani  { get; set; }
        public decimal SiparisTutari { get; set; }
        
        //NP
        public Kitap Kitap { get; set; }
        public Siparis Siparis { get; set; }

    }
}
