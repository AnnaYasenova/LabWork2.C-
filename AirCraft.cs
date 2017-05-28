using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    abstract class AirCraft
    {
        protected string name;
        protected double price;
        protected int madeYear;
        protected double speed;
        protected string mark;
        
        public AirCraft(string name, double price, int madeYear, double speed, string mark)
        {
            this.name = name;
            this.price = price;
            this.madeYear = madeYear;
            this.speed = speed;
            this.mark = mark;
        }
        public AirCraft()
        {
            this.name = null;
            this.price = 0;
            this.madeYear = DateTime.Today.Year;
            this.speed = 0;
            this.mark = null;
        }
 
        public string Name
        {
            get; set;
        }
        public double Speed
        {
            get;
            set;
        }
        public string Mark
        { get; set; }
        public int MadeYear
        { get; set; }
        public double Price
        { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}\nPrice: {1}\nMade in: {2}\nMax speed: {3}\n", name, price, madeYear, speed);
        }
        

    }
}
