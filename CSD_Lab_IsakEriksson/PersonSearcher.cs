﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD_Lab_IsakEriksson
{
    /// <summary>
    /// The more specific PersonSearcher inherits the generic Searcher with Person as parameter.
    /// It utilizes the generic BasicSearch from the superclass to perform relevant searches on its InMemoryStorage object.
    /// In the future, this class might be extended with more advanced searching methods, specific to searching for persons.
    /// A PersonSearcher performs the searches on a local storage and returns the results as a list.
    /// </summary>
    public class PersonSearcher : Searcher<Person>
    {
        private InMemoryStorage<Person> pStorage;

        public PersonSearcher(InMemoryStorage<Person> pStorage)
        {
            this.pStorage = pStorage;
        }

        /// <summary>
        /// Utilizes the inherited BasicSearch to perform a search on a given firstName of a Person.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<Person> FirstNameSearch(string name)
        {
            List<Person> results = BasicSearch(pStorage, "GetFirstName", name);
            return results;
        }

        /// <summary>
        /// Utilizes the inherited BasicSearch to perform a search on a given lastName of a Person.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<Person> LastNameSearch(string name)
        {
            List<Person> results = BasicSearch(pStorage, "GetLastName", name);
            return results;
        }

        /// <summary>
        /// Utilizes the inherited BasicSearch to perform a search on a given phoneNumber of a Person.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public List<Person> PhoneNumberSearch(string number)
        {
            List<Person> results = BasicSearch(pStorage, "GetPhoneNumber", number);
            return results;
        }

        public List<Person> BirthDateSearch(DateTime birthDate)
        {
            return DateSearch(pStorage, "GetBirthDate", birthDate);
        }

        public List<Person> BirthDateIntervalSearch(DateTime fromDate, DateTime toDate)
        {
            List<Person> results = new List<Person>();
            foreach (Person p in pStorage)
            {
                DateTime birthDate = p.GetBirthDate();
                if (birthDate.CompareTo(fromDate) >= 0 && birthDate.CompareTo(toDate) <= 0)
                {
                    results.Add(p);
                }
            }
            return results;
        }
    }
}