using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD_Lab_IsakEriksson
{
    interface IStorage<T> : IEnumerable<T>
    {
        void Create(T item);
        T Read(int identifier);
        void Update(int identifier, T item);
        void Delete(int identifier);
        
        //Implementing IEnumerable interface members
        IEnumerator<T> GetEnumerator();

    }
}
