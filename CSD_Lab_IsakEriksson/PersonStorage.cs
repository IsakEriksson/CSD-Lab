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
    class PersonStorage : IStorage<Person>
    {
        private List<Person> storage { get; set; }

        public PersonStorage()
        {
            this.storage = new List<Person>();
        }

        //Implementing IEnumerable interface members
        public IEnumerator<Person> GetEnumerator()
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
        public void Create(Person person)
        {
            storage.Add(person);
        }

        /// <summary>
        /// Reads a person by its Id from the storage. Part of basic CRUD.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Person Read(int id)
        {
            return storage.Find(person => person.GetId() == id);
        }

        /// <summary>
        /// Updates a specific person by its Id, given an updated Person object. Part of basic CRUD.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updatedPerson"></param>
        public void Update(int id, Person updatedPerson)
        {
            Person person = Read(id);
            int index = storage.IndexOf(person);
            storage[index] = updatedPerson;
        }

        /// <summary>
        /// Deletes a specific person by its Id. Part of basic CRUD.
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            Person person = Read(id);
            storage.Remove(person);
        }
    }
}