using KitaciUygulamasi.Entities.Abstracts.AbstractClass;
using KitapciUygulamasi.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;

namespace KitapciUygulamasi.Mapping
{
    public abstract class BaseEntityMapping<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> baseEntity)
        {
            baseEntity.Property(x => x.CreatedDate).IsRequired().HasDefaultValue(DateTime.Now.ToShortDateString());
            baseEntity.Property(x => x.CreatedBy).HasMaxLength(128).IsRequired(false);
            baseEntity.Property(x => x.ModifiedDate).IsRequired().HasDefaultValue(DateTime.Now.ToShortDateString());
            baseEntity.Property(x => x.ModifiedBy).HasMaxLength(128).IsRequired(false);

        }
    }
}
