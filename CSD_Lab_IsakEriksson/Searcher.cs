using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace CSD_Lab_IsakEriksson
{
    class Searcher<T>
    {
        List<T> results = new List<T>();
        public List<T> BasicSearch(IStorage<T> storage, string function, string searchString)
        {
            Type thistype = typeof(T);
            MethodInfo method = thistype.GetMethod(function);
            foreach (T item in storage)
            {
                string something = method.Invoke(item, null).ToString();
                Console.WriteLine(something);
                if (something == searchString) 
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
