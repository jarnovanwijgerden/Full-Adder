using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Full_Adder
{
    public class NodeOR : Node
    {
        public NodeOR()
        {

        }
        public override bool execute()
        {
            return (this.Input[0] == true || this.Input[1] == true);
        }
    }
}
