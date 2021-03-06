﻿using System;
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

        /// <summary>
        /// With the PersonFactory class, the factory pattern is implemented.
        /// This class is the only class with access to the constructor of the Person class,
        /// meaning it is the only way of creating Person objects.
        /// </summary>
        public class PersonFactory
        {
            private IDIndexer pIndexer;
            private CSV_parser csv_parser;
            public PersonFactory()
            {
                pIndexer = new IDIndexer();
                csv_parser = new CSV_parser();
            }
            public Person CreatePerson(string firstName, string lastName, string phonenumber, DateTime birthDate)
            {
                return new Person(pIndexer.GetId(), firstName, lastName, phonenumber, birthDate);
            }

            public List<Person> CreatePeople(string csv_people)
            {
                List<Person> people = new List<Person>();
                object[][] people_data = csv_parser.Parse_CSV(csv_people);
                for (int i = 0; i < people_data.GetLength(0); i++)
                {
                    people.Add(new Person(pIndexer.GetId(), people_data[i][0].ToString(), people_data[i][1].ToString(), people_data[i][2].ToString(), Convert.ToDateTime(people_data[i][3])));
                }
                return people;
            }
        }
    }
}