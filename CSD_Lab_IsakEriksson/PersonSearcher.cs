using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD_Lab_IsakEriksson
{
    /// <summary>
    /// The more specific PersonSearcher inherits the generic Searcher with Person as parameter.
    /// It utilizes the generic BasicSearch from the superclass to perform relevant searches on its PersonStorage object.
    /// In the future, this class will get more advanced searching methods that will be specific to searching for persons.
    /// A PersonSearcher performs the searches on a local storage and returns the results as a list.
    /// </summary>
    class PersonSearcher : Searcher<Person>
    {
        PersonStorage storage { get; set; }

        public PersonSearcher(PersonStorage storage)
        {
            this.storage = storage;
        }

        /// <summary>
        /// Utilizes the inherited BasicSearch to perform a search on a given firstName of a Person.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<Person> FirstNameSearch(string name)
        {
            List<Person> results = BasicSearch(storage, "GetFirstName", name);
            return results;
        }

        /// <summary>
        /// Utilizes the inherited BasicSearch to perform a search on a given lastName of a Person.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<Person> LastNameSearch(string name)
        {
            List<Person> results = BasicSearch(storage, "GetLastName", name);
            return results;
        }

        /// <summary>
        /// Utilizes the inherited BasicSearch to perform a search on a given phoneNumber of a Person.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public List<Person> NumberSearch(string number)
        {
            List<Person> results = BasicSearch(storage, "GetPhoneNumber", number);
            return results;
        }
    }
}