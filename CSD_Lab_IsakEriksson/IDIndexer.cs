using System;
namespace CSD_Lab_IsakEriksson
{
    /// <summary>
    /// The public class IDIndexer serves the purposes of providing unique integer IDs.
    /// This class does not rely on static properties.
    /// </summary>
    public class IDIndexer
    {
        int id;
        public IDIndexer()
        {
            id++;
        }
        public int GetId()
        {
            return id++;
        }
    }
}
