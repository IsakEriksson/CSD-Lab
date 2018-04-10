using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD_Lab_IsakEriksson
{
    /// <summary>
    /// The class Person indicates what attributes a person possesses.
    /// Also gives methods to access specific attributes otherwise not available.
    /// Each person has an Id which is incrementally assigned.
    /// </summary>
    class Person
    {
        private int id { get; set; }
        private static int counter;
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string phoneNumber { get; set; }

        public Person(string firstName, string lastName, string phonenumber)
        {
            this.id = ++counter;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phonenumber;
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
    }
}