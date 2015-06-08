using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Full_Adder.exception
{
    class UnknownNodeTypeException : Exception
    {
        //Constructor voor het afhandelen van de exception (Message tonen)
        public UnknownNodeTypeException()
        {
            Console.WriteLine("Error, Unknown node type");
        }
    }
}
