using Full_Adder.exception;
using Full_Adder.nodes;
using System;
using System.Collections.Generic;
namespace Full_Adder
{
    public class Circuit
    {
        public void startCircuit(List<Node> n)
        {
            var query = n.FindAll(nodes => nodes.GetType().Name == "INPUT_HIGH" || nodes.GetType().Name == "INPUT_LOW");
            foreach (Node input in query)
            {
                addInputToProbe(input);
            }
            finishedCircuit(n);
        }
        private void addInputToProbe(Node input)
        {
            if (input.GetType().Name == "INPUT_HIGH")
            {
                input.addInput(true);
            }
            else
            {
                input.addInput(false);
            }
        }
        private void finishedCircuit(List<Node>n)
        {
            Console.WriteLine("\n\nUitkomst van circuit\n");
            var query = n.FindAll(nodes => nodes.GetType().Name == "PROBE");
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
