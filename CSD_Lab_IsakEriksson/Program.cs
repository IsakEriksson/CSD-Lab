using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD_Lab_IsakEriksson
{
    class Program
    {
        static void Main(string[] args)
        {
            InMemoryStorage<Person> pStorage = new InMemoryStorage<Person>();
            InMemoryStorage<Organization> orgStorage = new InMemoryStorage<Organization>();

            Person.PersonFactory pFactory = new Person.PersonFactory();
            Organization.OrganizationFactory orgFactory = new Organization.OrganizationFactory();

            Person isak = pFactory.CreatePerson("Isak", "Eriksson", "+46738462851", new DateTime(1993, 8, 31));
            Person juan = pFactory.CreatePerson("Juan Pablo", "Torres Padilla", "+46736763542", new DateTime(1992, 9, 22));

            Organization uu = orgFactory.CreateOrganization("Uppsala universitet", "S:T Olofsgatan 10B", "Uppsala", "0184710000", new DateTime(1477, 2, 27));
            Organization oj = orgFactory.CreateOrganization("Oscar Jacobson", "Vevgatan 1", "Borås", "+4633233300", new DateTime(1903, 1, 1));

            pStorage.Create(isak);
            pStorage.Create(juan);

            orgStorage.Create(uu);
            orgStorage.Create(oj);

            PersonSearcher ps = new PersonSearcher(pStorage);

            List<Person> results = ps.BirthDateIntervalSearch(new DateTime(1992, 9, 23), new DateTime(1993, 9, 1));

            CSV_parser csvp = new CSV_parser();
            string csvtest = "isak, eriksson, 123, 93/08/31; juna, poblo, 123, 92/01/31";
            
            List<Person> peopre = pFactory.CreatePeople(csvtest);
        }
    }
}
