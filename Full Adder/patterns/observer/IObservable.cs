using Full_Adder.nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Full_Adder.observer
{
    //Interface voor IObservable Pattern
    interface IObservable
    {
        //Methodes die geimplementeerd moeten worden
        void Register(Node node);
        void UnRegister(Node node);
    }
}
