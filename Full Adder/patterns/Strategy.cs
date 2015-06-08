using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Full_Adder.patterns
{
    public abstract class Strategy
    {
        //Strategy Pattern methodes moeten geimplementeerd worden
        public abstract bool execute();
        public abstract bool result();
    }
}
