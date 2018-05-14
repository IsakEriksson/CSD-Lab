using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD_Lab_IsakEriksson
{
    /// <summary>
    /// The public class Person indicates what attributes a person possesses.
    /// In order to force a certain behaviour (for now, the method GetId) the class implements
    /// the ISearchable interface.
    /// Also gives methods to access specific attributes otherwise not available.
    /// </summary>
    public class Person : ISearchable
    {
        public int id { get; private set; }
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public string phoneNumber { get; private set; }
        public DateTime birthDate { get; private set; }

        private Person(int id, string firstName, string lastName, string phonenumber, DateTime birthDate)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phonenumber;
            this.birthDate = birthDate;
        }

        /// <summary>
        /// Returns the Id of a Person.
        /// </summary>
        /// <returns></returns>
        public int GetId()
        {
            return this.id;
        }

        /// <summary>
        /// Returns the first name of a Person.
        /// </summary>
        /// <returns></returns>
        public string GetFirstName()
        {
            return this.firstName;
        }

        /// <summary>
        /// Returns the last name of a Person.
        /// </summary>
        /// <returns></returns>
        public string GetLastName()
        {
            return this.lastName;
        }

        /// <summary>
        /// Returns the phone number of a Person.
        /// </summary>
        /// <returns></returns>
        public string GetPhoneNumber()
        {
            return this.phoneNumber;
        }

        /// <summary>
        /// Return the birth date of a Person.
        /// </summary>
        /// <returns></returns>
        public DateTime GetBirthDate()
        {
            return this.birthDate;
        }

        public class PersonFactory
        {
            private IDIndexer pIndexer;
            public PersonFactory()
            {
                pIndexer = new IDIndexer();
            }
            public Person CreatePerson(string firstName, string lastName, string phonenumber, DateTime birthDate)
            {
                Person newPerson = new Person(pIndexer.GetId(), firstName, lastName, phonenumber, birthDate);
                return newPerson;
            }
        }
    }
}