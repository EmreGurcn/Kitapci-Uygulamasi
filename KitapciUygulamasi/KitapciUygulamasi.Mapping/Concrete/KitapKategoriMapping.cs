using KitaciUygulamasi.Entities.Abstracts.AbstractClass;
using KitaciUygulamasi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapciUygulamasi.Mapping.Concrete
{
    public class KitapKategoriMapping:BaseEntityMapping<KitapKategori>
    {
        public override void Configure(EntityTypeBuilder<KitapKategori> kitapKategori)
        {
            kitapKategori.HasKey(k => new { k.KitapID, k.KategoriID});
            base.Configure(kitapKategori);


        }
    }
}
