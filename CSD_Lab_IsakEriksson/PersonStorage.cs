using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD_Lab_IsakEriksson
{
    class PersonStorage : IStorage<Person>
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

        public Person Read(string firstName)
        {
            return storage.Find(person => person.GetFirstName() == firstName);
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