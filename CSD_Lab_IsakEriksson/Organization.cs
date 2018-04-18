using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD_Lab_IsakEriksson
{
    public class Organization : ISearchable
    {
        private int id;
        public readonly string name;
        public readonly string address;
        public readonly string city;
        public readonly string phoneNumber;
        private readonly DateTime foundingDate;

        public Organization(int id, string name, string address, string city, string phoneNumber, DateTime foundingDate)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.city = city;
            this.phoneNumber = phoneNumber;
            this.foundingDate = foundingDate;
        }

        public int GetId()
        {
            return this.id;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetAddress()
        {
            return this.address;
        }

        public string GetCity()
        {
            return this.city;
        }

        public string GetPhoneNumber()
        {
            return this.phoneNumber;
        }

        public DateTime GetFoundingDate()
        {
            return this.foundingDate;
        }
    }
}
