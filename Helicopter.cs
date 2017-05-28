using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Helicopter : AirCraft
    {
        private double high;
        private int capacity;
        public Helicopter() { this.high = 0;
        this.capacity = 0;
        }
        public Helicopter(string name, double price, int madeYear, double speed, string mark, double high, int capacity)
            : base(name, price, madeYear, speed, mark)
        {
            this.high = high;
            if (capacity < 0)
                throw new myException("Capacity parameter must be greater than zero");
            else
                this.capacity = capacity;
        }
        public double High
        {
            get;
            set;
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
            return base.ToString() + string.Format("Capacity: {0}\nHigh: {1}\n", capacity, high);
        }

        public override bool Equals(Object obj)
        {
            if (!(obj is Helicopter)) return false;

            Helicopter p = (Helicopter)obj;
            return name == p.Name & price == p.price & madeYear == p.madeYear & speed == p.speed & mark == p.mark & capacity == p.capacity;
        }

        public override int GetHashCode()
        {
            return madeYear + capacity;
        }


        public static Boolean operator ==(Helicopter p1, Helicopter p2)
        {
            return p1.Equals(p2);
        }

        public static Boolean operator !=(Helicopter p1, Helicopter p2)
        {
            return !(p1.Equals(p2));
        }
    }
}
