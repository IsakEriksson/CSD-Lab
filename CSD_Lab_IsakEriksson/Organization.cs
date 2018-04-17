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
        public readonly string phoneNumber;
        private readonly DateTime foundingDate;

        public Organization(int id, string name, string address, string phoneNumber, DateTime foundingDate)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.foundingDate = foundingDate;
        }

        public int GetId()
        {
            return this.id;
        }

    }
}
