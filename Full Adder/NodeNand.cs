using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Full_Adder
{
    public class NodeNand : Node
    {
        public override bool execute()
        {
            if(this.Input[0] == this.Input[1] && this.Input[1] == false || this.Input[0] != this.Input[1])
            {
                return true;
            }
            return false;
        }
    }
}
