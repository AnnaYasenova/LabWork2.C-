using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Airport
    {
        List<AirCraft> coll;
        public Airport() { 
            coll = new List<AirCraft>();
        }

        public void add(AirCraft item)
        {
            coll.Add(item);
        }

        public void print()
        {
            foreach (AirCraft i in coll)
            {
                Console.WriteLine(i.ToString());
            }
        }

    }
}
