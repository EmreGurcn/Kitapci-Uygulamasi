using KitaciUygulamasi.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapciUygulamasi.Mapping.Concrete
{
    public class KitapYayinEviMapping:BaseEntityMapping<KitapYayinEvi>
    {
        public override void Configure(EntityTypeBuilder<KitapYayinEvi> kitapYayinEvi)
        {
            kitapYayinEvi.HasKey(y => new { y.KitapID, y.YayinEviID });
            base.Configure(kitapYayinEvi);
        }
    }
}
