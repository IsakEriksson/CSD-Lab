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
            Person isak = new Person("Isak", "Eriksson", "123");
            Person juan = new Person("Juan Pablo", "Torres Padilla", "456");
            Person joan = new Person("Joan", "Jonathan", "789");
            Person omar = new Person("Omar", "Salah", "101112");
            
            PersonStorage storage = new PersonStorage();
            
            storage.Create(isak);
            storage.Create(juan);
            storage.Create(joan);
            storage.Create(omar);

            Person isakcopy = storage.Read(1);
            storage.Create(isakcopy);
            List<Person> searchresults = storage.Read("Eriksson");

            Person newomar = new Person("Omar", "Salah", "121110");
            storage.Update(4, newomar);

            storage.Delete(4);
            
            Console.ReadKey();
        }
    }
}
