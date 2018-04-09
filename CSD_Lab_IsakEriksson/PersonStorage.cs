using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD_Lab_IsakEriksson
{
    class PersonStorage : IStorage<Person, int>, IEnumerable<Person>
    {
        private List<Person> storage { get; set; }

        public PersonStorage()
        {
            this.storage = new List<Person>();
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

        public List<Person> Read(string name)
        {
            List<Person> results = new List<Person>();
            foreach (Person person in storage)
            {
                if ((person.GetFirstName() == name) || (person.GetLastName() == name))
                {
                    results.Add(person);
                }
            }
            return results;
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

        //Implementation of Enumerable interface members
        public IEnumerator<Person> GetEnumerator()
        {
            return storage.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}