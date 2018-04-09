using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD_Lab_IsakEriksson
{
    class PersonStorage : IStorage<Person>, IEnumerable<Person>
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

        //CRUD funcitonality
        public void Create(Person person)
        {
            storage.Add(person);
        }

        public Person Read(int id)
        {
            return storage.Find(person => person.GetId() == id);
        }

        public void Update(int id, Person updatedPerson)
        {
            Person person = Read(id);
            int index = storage.IndexOf(person);
            storage.Insert(index, updatedPerson);
        }

        public void Delete(int id)
        {
            Person person = Read(id);
            storage.Remove(person);
        }
    }
}