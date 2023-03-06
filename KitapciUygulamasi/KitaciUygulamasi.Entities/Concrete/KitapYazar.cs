using KitaciUygulamasi.Entities.Abstracts.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitaciUygulamasi.Entities.Concrete
{
    public class KitapYazar:BaseEntity
    {
        public int KitapID { get; set; }
        public int YazarID { get; set; }

        public Yazar Yazar { get; set; }
        public Kitap Kitap { get; set; }
    }
}
