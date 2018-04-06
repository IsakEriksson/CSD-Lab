using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD_Lab_IsakEriksson
{
    interface IStorage<T>
    {
        void Create(T item);
        T Read(T identifier);
        void Update(T identifier, T item);
        void Delete(T identifier);
    }
}
