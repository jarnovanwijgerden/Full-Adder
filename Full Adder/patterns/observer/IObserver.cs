﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Full_Adder.observer
{
    interface IObserver
    {
        void Notify(bool value);
    }
}
