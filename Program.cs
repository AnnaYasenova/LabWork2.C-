using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Airport A = new Airport();
            Plane plane = new Plane("Plane", 19985.4, 2005, 200.6, "BT-89", 45);
            Helicopter helicopter = new Helicopter("Helicopter", 489732.45, 1998, 789.7, "TR-42", 50.1, 21);
            Freighter freighter = new Freighter("Freighter", 65456.12, 2016, 454.8, "QW-6", 54, "Odessa");
            A.add(plane);
            A.add(helicopter);
            A.add(freighter);
            A.print();
            System.Console.ReadKey();
        }
    }
}
