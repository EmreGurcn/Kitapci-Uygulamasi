using KitaciUygulamasi.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapciUygulamasi.Mapping.Concrete
{
    public class KitapYazarMapping:BaseEntityMapping<KitapYazar>
    {
        public override void Configure(EntityTypeBuilder<KitapYazar> kitapYazar)
        {
            kitapYazar.HasKey(y => new { y.KitapID, y.YazarID });
            base.Configure(kitapYazar);
        }
    }
}
