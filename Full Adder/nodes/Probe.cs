﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Full_Adder.nodes
{
    class Probe : Node
    {
        public bool result()
        {
            return Input[0];
        }
    }
}
