using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD_Lab_IsakEriksson
{
    //This should later on inherit basic search functions from a superclass
    class PersonSearcher : Searcher<Person>
    {
        PersonStorage storage { get; set; }

        public PersonSearcher(PersonStorage storage)
        {
            this.storage = storage;
        }

        public List<Person> NameSearch(string name)
        {
            List<Person> results;
            results = BasicSearch(storage, "GetFirstName", name);
            results = BasicSearch(storage, "GetLastName", name);
            return results;
        }

        /*public List<Person> NameSearch(string name)
        {
            List<Person> results = new List<Person>();
            foreach (Person person in storage)
            {
                if ((person.GetFirstName() == name) || (person.GetLastName() == name) || person.GetFirstName().Contains(name) || person.GetLastName().Contains(name))
                {
                    results.Add(person);
                }
            }
            return results;
        }
        */
        public List<Person> NumberSearch(string number)
        {
            List<Person> results = new List<Person>();
            foreach (Person person in storage)
            {
                if ((person.GetPhoneNumber() == number) || person.GetPhoneNumber().Contains(number))
                {
                    results.Add(person);
                }
            }
            return results;
        }
    }
}