using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Full_Adder
{
    public class Parser
    {
        public Parser()
        {
            int counter = 0;
            string line;
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;

            
            System.IO.StreamReader file =
               new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
                counter++;
            }

            file.Close();

            Console.WriteLine(path);
            
            Console.ReadLine();          
        }
    }
}
