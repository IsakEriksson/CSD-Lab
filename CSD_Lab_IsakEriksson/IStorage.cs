using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD_Lab_IsakEriksson
{
    /// <summary>
    /// The generic interface for any Storage class.
    /// Supports basic CRUD operations and an IEnumerator.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IStorage<T> : IEnumerable<T>
    {
        void Create(T item);
        T Read(int identifier);
        void Update(int identifier, T item);
        void Delete(int identifier);
        
        //Implementing necessary IEnumerable interface member GetEnumerator()
        IEnumerator<T> GetEnumerator();
    }
}
