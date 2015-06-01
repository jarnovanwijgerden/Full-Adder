using Full_Adder.exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Full_Adder.nodes
{
    class Probe : Node
    {
        public override bool result()
        {
            if(Input.Count == 0)
            {
                throw new UnconnectedPinsException();
            }
            return Input[0];
        }
        public override bool execute()
        {
            return Input[0];
        }
    }
}
