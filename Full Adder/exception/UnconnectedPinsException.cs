using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Full_Adder.exception
{
    class UnconnectedPinsException : Exception
    {
        public UnconnectedPinsException()
        {
            Console.WriteLine("Error, unconnected pins exception");
        }
    }
}
