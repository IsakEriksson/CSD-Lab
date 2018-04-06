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
            
            Person fakejuan = storage.Read(2);
            storage.Create(fakejuan);

            Person newjoan = new Person("Joan", "Jonathan", "987");
            storage.Update(3, newjoan);

            Console.WriteLine("Come on GIT you bastard");

            Console.ReadKey();
        }
    }
}
