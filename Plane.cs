using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Plane : AirCraft
    {
        private int capacity;
        public Plane() { }
        public Plane(string name, double price, int madeYear, double speed, string mark, int capacity)
            : base(name, price, madeYear, speed, mark) { this.capacity=capacity;}
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
            return base.ToString() + string.Format("Capacity: {0}\n", capacity);
        }

        public override bool Equals(Object obj)
        {
            if (!(obj is Plane)) return false;

            Plane p = (Plane)obj;
            return name == p.Name & price == p.price & madeYear == p.madeYear & speed == p.speed & mark == p.mark & capacity == p.capacity;
        }

        public override int GetHashCode()
        {
            return madeYear + capacity;
        }

        public static Boolean operator ==(Plane p1, Plane p2){
            return p1.Equals(p2);
        }

        public static Boolean operator !=(Plane p1, Plane p2)
        {
            return !(p1.Equals(p2));
        }
    }
}
