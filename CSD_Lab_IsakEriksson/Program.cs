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
            // Create indexer.
            IDIndexer personIndexer = new IDIndexer();

            // Simply displaying different methods implemented for examples of individuals.
            Person isak = new Person(personIndexer.GetId(), "Isak", "Eriksson", "123");
            Person juan = new Person(personIndexer.GetId(), "Juan Pablo", "Torres Padilla", "456");
            Person joan = new Person(personIndexer.GetId(), "Joan", "Jonathan", "789");
            Person omar = new Person(personIndexer.GetId(), "Omar", "Salah", "101112");
            
            PersonStorage storage = new PersonStorage();
            
            // Creating.
            storage.Create(isak);
            storage.Create(juan);
            storage.Create(joan);
            storage.Create(omar);

            // Reading.
            Person isakcopy = storage.Read(1);

            // Updating.
            Person newomar = new Person(personIndexer.GetId(), "Omar", "Salah", "121110");
            storage.Update(4, newomar);

            // Deleting.
            storage.Delete(4);

            PersonSearcher searcher = new PersonSearcher(storage);
            
            // Searching.
            List<Person> last_name_results = searcher.LastNameSearch("Eriksson");
            List<Person> first_name_results = searcher.FirstNameSearch("J");
            List<Person> number_results = searcher.NumberSearch("123");
            List<Person> more_number_results = searcher.NumberSearch("1");

            Console.WriteLine(last_name_results.ToString());

            Console.ReadKey();
        }
    }
}
