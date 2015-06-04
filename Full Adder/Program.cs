using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Full_Adder
{
    class Program
    {
        static String input = "";
        static void Main(string[] args)
        {
           
            do
            {
                showInfo();
                askForInput();

            } while (true);
        }
        private static void showInfo()
        {
            Console.WriteLine("Welkom bij Full Adder");
            Console.WriteLine("Kies een bestand (Typ de volledige naam bijv 'circuit1' ) \n");
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\circuits";
            string[] files = Directory.GetFiles(path);
            foreach (string name in files)
            {
                Console.WriteLine("Bestand {0} ", Path.GetFileName(name));
            }
        }
        private static void askForInput()
        {
            input = Console.ReadLine();
            if (input.ToLower() != "exit")
            {
                Parser p = new Parser(input + ".txt");
            }
            Console.ReadLine();
        }
    }
}