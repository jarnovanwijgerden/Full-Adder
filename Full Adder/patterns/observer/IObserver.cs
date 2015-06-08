using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Full_Adder.observer
{
    //Interface voor IObservable Pattern
    interface IObserver
    {
        //Methode die geimplementeerd moet worden
        void Notify(bool value);
    }
}
