using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD_Lab_IsakEriksson
{
    /// <summary>
    /// The more specific OrganizationSearcher inherits the generic Searcher with Organization as parameter.
    /// It utilizes the generic BasicSearch from the superclass to perform relevant searches on its InMemoryStorage object.
    /// In the future, this class could be extended with more advanced searching methods, specific to searching for organizations.
    /// An OrganizationSearcher performs the searches on a local storage and returns the results as a list.
    /// </summary>
    public class OrganizationSearcher : Searcher<Organization>
    {
        InMemoryStorage<Organization> orgStorage;

        public OrganizationSearcher(InMemoryStorage<Organization> orgStorage)
        {
            this.orgStorage = orgStorage;
        }

        /// <summary>
        /// Utilizes the inherited BasicSearch to perform a search on a given name of an Organization.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<Organization> NameSearch(string name)
        {
            return BasicSearch(orgStorage, "GetName", name);
        }

        /// <summary>
        /// Utilizes the inherited BasicSearch to perform a search on a given address of an Organization.
        /// </summary>
        /// <param name="addresss"></param>
        /// <returns></returns>
        public List<Organization> AddressSearch(string address)
        {
            return BasicSearch(orgStorage, "GetAddress", address);
        }

        /// <summary>
        /// Utilizes the inherited BasicSearch to perform a search on a given city of an Organization.
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        public List<Organization> CitySearch(string city)
        {
            return BasicSearch(orgStorage, "GetCity", city);
        }

        /// <summary>
        /// Utilizes the inherited BasicSearch to perform a search on a given phoneNumber of an Organization.
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public List<Organization> PhoneNumberSearch(string phoneNumber)
        {
            return BasicSearch(orgStorage, "GetPhoneNumber", phoneNumber);
        }

        /// <summary>
        /// As the search term is not of type string, BasicSearch cannot be utilized here.
        /// However, since InMemoryStorage implements the IEnumerable interface, pStorage
        /// can be iterated through via foreach. This is done and every item that has a
        /// birth date equal to the search term, it is added to the results list, which is returned.
        /// </summary>
        /// <param name="foundingDate"></param>
        /// <returns></returns>
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
