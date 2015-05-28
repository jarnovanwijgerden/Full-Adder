using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Full_Adder
{
    public class NodeNor : Node
    {
        public override bool execute()
        {
            return (this.Input[0] == false && this.Input[1] == false);
        }
    }
}
