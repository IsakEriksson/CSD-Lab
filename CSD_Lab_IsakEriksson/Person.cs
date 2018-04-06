using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD_Lab_IsakEriksson
{
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

        public int GetId()
        {
            return this.id;
        }

        public string GetFirstName()
        {
            return this.firstName;
        }

        public string GetLastName()
        {
            return this.lastName;
        }

        public string GetPhoneNumber()
        {
            return this.phoneNumber;
        }
    }
}