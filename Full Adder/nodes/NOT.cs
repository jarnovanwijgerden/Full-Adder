using System;
using System.Collections.Generic;
using System.Linq;
namespace Full_Adder.nodes
{
    public class NOT : Node
    {
        public NOT()
        {
            this.Inputcount = 1;
            this.ExtraInfo = "NOT";
        }
        //Overschrijven van de methode (Strategy pattern)
        public override bool execute()
        {
            return !this.Input[0];
        }
    }
}
