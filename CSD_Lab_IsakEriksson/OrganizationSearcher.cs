using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD_Lab_IsakEriksson
{
    public class OrganizationSearcher : Searcher<Organization>
    {
        InMemoryStorage<Organization> orgStorage;

        public OrganizationSearcher(InMemoryStorage<Organization> orgStorage)
        {
            this.orgStorage = orgStorage;
        }

        public List<Organization> NameSearch(string name)
        {
            return BasicSearch(orgStorage, "GetName", name);
        }

        public List<Organization> AddressSearch(string address)
        {
            return BasicSearch(orgStorage, "GetAddress", address);
        }

        public List<Organization> CitySearch(string city)
        {
            return BasicSearch(orgStorage, "GetCity", city);
        }

        public List<Organization> PhoneNumberSearch(string phoneNumber)
        {
            return BasicSearch(orgStorage, "GetPhoneNumber", phoneNumber);
        }

        public List<Organization> FoundingDateSearch(DateTime foundingDate)
        {
            List<Organization> results = new List<Organization>();
            foreach(Organization org in orgStorage)
            {
                if(org.GetFoundingDate().Equals(foundingDate))
                {
                    results.Add(org);
                }
            }

            return results;
        }
    }
}
