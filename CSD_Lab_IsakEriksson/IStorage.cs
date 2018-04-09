using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD_Lab_IsakEriksson
{
    interface IStorage<T, F>
    {
        void Create(T item);
        T Read(F identifier);
        void Update(F identifier, T item);
        void Delete(F identifier);
    }
}
