using Full_Adder.nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Full_Adder.observer
{
    interface IObservable
    {
        void Register(Node node);
        void UnRegister(Node node);
    }
}
