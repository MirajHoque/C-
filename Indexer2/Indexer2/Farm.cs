using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer2
{
    class Farm
    {
        string[] animals = new string[3];
        public string this[int index]
        {
            get
            {
                return animals[index];
            }
            set
            {
                animals[index] = value;
            }
        }
        
    }
}
