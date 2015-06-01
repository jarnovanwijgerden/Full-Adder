using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Full_Adder
{
    public class Parser
    {

        private Factory nodeFactory;
        private List<String> nodelines;
        private List<String> egdeslines;
        private String state = "nodes";
        private List<Node> nodes;
        public Parser(String filename)
        {
            nodelines = new List<string>();
            egdeslines = new List<string>();
            nodeFactory = new Factory();
            string line;
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\circuits\\" + filename;
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                    readLine(line);
                }
                nodeFactory.generateNodes(nodelines, egdeslines);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Foute invoer");
            }
           
        }
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
        //private void bindNodes()
        //{
        //    foreach (String line in nodelines) {


        //        Console.WriteLine("Nodeline " + line);
        //        //String[] parts = line.Trim().Split(':');

        //    }

        //    foreach (String line in egdeslines)
        //    {
        //        Console.WriteLine("Edgeline " + line);
        //    }
        //}
        
    }
}
