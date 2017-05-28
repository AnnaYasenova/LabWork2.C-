using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Freighter : AirCraft
    {
        private string port;
        private int capacity;
 
        public Freighter() {
            this.capacity = 0;
        this.port = null;
        }
        public Freighter(string name, double price, int madeYear, double speed, string mark, int capacity, string port)
            : base(name, price, madeYear, speed, mark)
        {
            this.port = port;
            if (capacity < 0)
                throw new myException("Capacity parameter must be greater than zero");
            else
            this.capacity = capacity;
        }
        public int Сapacity
        {
            
        get
        {
                return this.capacity;
            }
            set
            {
                if (value < 0)
                    throw new myException("Capacity parameter must be greater than zero");
                else
                    this.capacity = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("Capacity: {0}\nPort: {1}\n", capacity, port);
        }

        public override bool Equals(Object obj)
        {
            if (!(obj is Freighter)) return false;

            Freighter p = (Freighter)obj;
            return name == p.Name & price == p.price & madeYear == p.madeYear & speed == p.speed & mark == p.mark & capacity == p.capacity;
        }

        public override int GetHashCode()
        {
            return madeYear + capacity;
        }


        public static Boolean operator ==(Freighter p1, Freighter p2)
        {
            return p1.Equals(p2);
        }

        public static Boolean operator !=(Freighter p1, Freighter p2)
        {
            return !(p1.Equals(p2));
        }
    }
}
