using System;
namespace CSD_Lab_IsakEriksson
{
    class IDIndexer
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
