using Full_Adder.exception;
using Full_Adder.nodes;
using System;
using System.Collections.Generic;
namespace Full_Adder
{
    public class Circuit
    {
        //Methode voor het starten van de circuit
        public void startCircuit(List<Node> n)
        {
            //Ophalen van de bepaalde nodes, die gelijk uitgevoerd kunnen worden
            var query = n.FindAll(nodes => nodes.GetType().Name == "INPUT_HIGH" || nodes.GetType().Name == "INPUT_LOW");
            //Door elke node heen loopen
            foreach (Node input in query)
            {
                //Input toevoegen aan probe
                addInput(input);
            }
            //Methode voor het uitlezen van de resultaten
            finishedCircuit(n);
        }
        //methode voor het toevoegen van een probe
        private void addInput(Node input)
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
            //Alle probes ophalen, hierin staat de uitkomst van t circuit
            var query = n.FindAll(nodes => nodes.GetType().Name == "PROBE");
            try
            {
                //door elke probe loopen
                foreach (Node probe in query)
                {
                    //Resultaat van probe printen
                    Console.WriteLine("Probe {0} heeft als uitkomst {1}", probe.Name, probe.result());
                }
                //Wanneer deze geen resultaat heeft wordt er een exception gegooid en opgevangen
            }  catch (UnconnectedPinsException e)  {

            }
          
          
        }
      
        
    }
}
