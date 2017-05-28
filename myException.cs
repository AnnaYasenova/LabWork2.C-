using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class myException : Exception
    {
        public myException(string str) : base(str) {}
    }
}
