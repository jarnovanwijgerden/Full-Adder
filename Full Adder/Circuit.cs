using Full_Adder.exception;
using System;
using System.Collections.Generic;
namespace Full_Adder
{
    public class Circuit
    {
        public Circuit(List<Node>n)
        {
            var query = n.FindAll(nodes => nodes.GetType().Name == "NodeInputHigh" || nodes.GetType().Name == "NodeInputLow");
            foreach(Node input in query)
            {
                if(input.GetType().Name == "NodeInputHigh") {
                    input.addInput(true);
                }
                else {
                    input.addInput(false);
                }
            }
            finishedCircuit(n);
        }

        private void finishedCircuit(List<Node>n)
        {
            Console.WriteLine("Uitkomst van circuit");
            var query = n.FindAll(nodes => nodes.GetType().Name == "Probe");
            try
            {
                foreach (Node probe in query)
                {
                    Console.WriteLine("Probe {0} heeft als uitkomst {1}", probe.Name, probe.result());
                }
            }  catch (UnconnectedPinsException e)  {

            }
          
          
        }
      
        
    }
}
