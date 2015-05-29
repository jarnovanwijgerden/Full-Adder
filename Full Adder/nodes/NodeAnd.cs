using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Full_Adder
{
    public class NodeAnd : Node
    {
        public override bool execute()
        {
            return this.Input[0] == this.Input[1];
        }
    }
}
