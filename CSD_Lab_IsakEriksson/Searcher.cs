using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace CSD_Lab_IsakEriksson
{
    /// <summary>
    /// Searcher class is meant to be the most basic class for searchers.
    /// For now, it simply consists of the method BasicSearch, used for various searches mimicing the same behaviour.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Searcher<T>
    {
        /// <summary>
        /// BasicSearch is the most basal version of what a search is in this program.
        /// Taking a storage, performing a certain search function on it with a certain search string, it is highly flexible.
        /// </summary>
        /// <param name="storage"></param>
        /// <param name="function"></param>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public List<T> BasicSearch(IStorage<T> storage, string function, string searchString)
        {
            List<T> results = new List<T>();
            Type thistype = typeof(T);
            MethodInfo method = thistype.GetMethod(function);
            foreach (T item in storage)
            {
                string attributeValue = method.Invoke(item, null).ToString();
                if (attributeValue == searchString || attributeValue.Contains(searchString)) 
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
