using KitaciUygulamasi.Entities.Abstracts.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitaciUygulamasi.Entities.Concrete
{
    public class KitapYayinEvi:BaseEntity
    {
        public int KitapID { get; set; }
        public int YayinEviID { get; set; }

        //NP
        public Kitap Kitap { get; set; }
        public YayinEvi YayinEvi { get; set; }

    }
}
