using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Full_Adder
{
    public class Parser
    {
        //Private variablen aanmaken
        private Factory nodeFactory;
        private List<String> nodelines;
        private List<String> egdeslines;
        private String state = "nodes";
        public Parser(String filename)
        {
            //Lijst met nodes en afhankelijke lijnen maken
            nodelines = new List<string>();
            egdeslines = new List<string>();
            //Nieuwe instantie van factory aanmaken
            nodeFactory = new Factory();
            string line;
            //Bestand ophalen
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\circuits\\" + filename;
            try
            {
                //Bestand uitlezen lijn voor lijn
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                    readLine(line);
                }
                //Nodes aanmaken aan de hand van de lijnen 
                nodeFactory.generateNodes(nodelines, egdeslines);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Foute invoer " + e.ToString());
            }
        }
        //Controleren welke state we zitten (afhankelijk heden of nodes)
        private void readLine(String line)
        {
            if (!line.StartsWith("#"))
            {
                if (line.Trim() == "")
                {
                    state = "edges";
                }
                else
                {
                    if (state == "nodes")
                    {
                        nodelines.Add(line);
                    }
                    else
                    {
                        egdeslines.Add(line);
                    }
                }
            }
        }
    }
}
