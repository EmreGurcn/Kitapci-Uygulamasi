using KitapciUygulamasi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitaciUygulamasi.Entities.Abstracts.AbstractClass
{
    public abstract class BaseEntity : IBaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
