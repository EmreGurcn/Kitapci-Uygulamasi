using KitaciUygulamasi.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapciUygulamasi.Mapping.Concrete
{
    public class SiparisDetaylariMapping:BaseEntityMapping<SiparisDetayi>
    {
        public override void Configure(EntityTypeBuilder<SiparisDetayi> siparisDetayi)
        {
            siparisDetayi.HasKey(s => new { s.SiparisID, s.KitapID });
            base.Configure(siparisDetayi);
        }
    }
}
