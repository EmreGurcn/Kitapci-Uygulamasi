using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapciUygulamasi.Core.Interfaces
{
    public interface IRepositoryForGuidID<T>
    {
        T GetByID(Guid id);
    }
}
