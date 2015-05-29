using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Full_Adder
{
    public class Parser
    {

        List<String> nodelines;
        List<String> egdeslines;
        String state = "nodes";
        List<Node> nodes;
        public Parser(String filename)
        {
            nodelines = new List<string>();
            egdeslines = new List<string>();
            string line;
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\circuits\\" + filename;
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                    readLine(line);
            }
            bindNodes();
            Console.ReadLine();          
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
        private void bindNodes()
        {
            foreach (String line in nodelines) {


                Console.WriteLine("Nodeline " + line);
                //String[] parts = line.Trim().Split(':');

            }

            foreach (String line in egdeslines)
            {
                Console.WriteLine("Edgeline " + line);
            }
        }
        
    }
}
