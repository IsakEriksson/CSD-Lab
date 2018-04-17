using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD_Lab_IsakEriksson
{
    /// <summary>
    /// The specific PersonStorage class, implementing IStorage interface with Person as parameter.
    /// A PersonStorage always has a list as an attribute which serves as the actual storage.
    /// </summary>
    public class InMemoryStorage<T> : IStorage<T> where T : ISearchable
    {
        private List<T> storage;

        public InMemoryStorage()
        {
            this.storage = new List<T>();
        }

        //Implementing IEnumerable interface members
        public IEnumerator<T> GetEnumerator()
        {
            return storage.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        /// <summary>
        /// Creates a person by adding it to the storage. Part of basic CRUD.
        /// </summary>
        /// <param name="person"></param>
        public void Create(T item)
        {
            storage.Add(item);
        }

        /// <summary>
        /// Reads a person by its Id from the storage. Part of basic CRUD.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T Read(int id)
        {
            return storage.Find(item => item.GetId() == id);
        }

        /// <summary>
        /// Updates a specific person by its Id, given an updated Person object. Part of basic CRUD.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updatedItem"></param>
        public void Update(int id, T updatedItem)
        {
            T element = Read(id);
            int index = storage.IndexOf(element);
            storage[index] = updatedItem;
        }

        /// <summary>
        /// Deletes a specific item by its Id. Part of basic CRUD.
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            T item = Read(id);
            storage.Remove(item);
        }
    }
}