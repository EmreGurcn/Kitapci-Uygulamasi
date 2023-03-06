using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitaciUygulamasi.Entities.Abstracts.Interfaces
{
    public interface IAdres
    {
        string Sehir { get; set; }
        public string Ilçe { get; set; }
        public string Mahalle { get; set; }
        public string AdresDetay { get; set; }
        public string PostaKodu { get; set; }

    }
}
