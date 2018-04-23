using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD_Lab_IsakEriksson
{
    /// <summary>
    /// The public class organization defines which attributes an organization possesses
    /// in the program.
    /// In order to make sure the class has a GetId method, the interface ISearchable is inherited.
    /// Furthermore every attribute of the class is returned through separate Get methods
    /// </summary>
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

        /// <summary>
        /// Returns the Id of an organization.
        /// </summary>
        /// <returns></returns>
        public int GetId()
        {
            return this.id;
        }

        /// <summary>
        /// Returns the name of an organization
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return this.name;
        }

        /// <summary>
        /// Returns the address of an organization.
        /// </summary>
        /// <returns></returns>
        public string GetAddress()
        {
            return this.address;
        }

        /// <summary>
        /// Returns the city of an organization.
        /// </summary>
        /// <returns></returns>
        public string GetCity()
        {
            return this.city;
        }

        /// <summary>
        /// Returns the phonenumber of an organization.
        /// </summary>
        /// <returns></returns>
        public string GetPhoneNumber()
        {
            return this.phoneNumber;
        }

        /// <summary>
        /// Returns the founding date of an organization.
        /// </summary>
        /// <returns></returns>
        public DateTime GetFoundingDate()
        {
            return this.foundingDate;
        }
    }
}
