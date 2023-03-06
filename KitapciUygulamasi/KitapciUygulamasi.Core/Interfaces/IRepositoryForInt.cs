using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapciUygulamasi.Core.Interfaces
{
    public interface IRepositoryForInt<T>
    {
        T GetByID(int id);
    }
}
