using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapciUygulamasi.Core.Interfaces
{
    public interface IBaseEntity
    {
        DateTime CreatedDate { get; set; }
        DateTime ModifiedDate { get; set; }
        string CreatedBy { get; set; }
        string ModifiedBy { get; set; }

    }
}
