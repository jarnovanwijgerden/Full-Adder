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

        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij Full Adder");
            Console.WriteLine("Kies een bestand (Typ de volledige naam) \n");
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\circuits";
            string[] files = Directory.GetFiles(path);
            foreach (string name in files) {
                Console.WriteLine("Bestand {0} ", Path.GetFileName(name));
            }
            String filename = Console.ReadLine();
            Parser p = new Parser(filename + ".txt");
            Console.ReadLine();
        }
    }
}

/*
 * == Stap 1: File wordt uitgelezen.
 * == Stap 2: Uit de file wordt per node een node aangemaakt d.m.v. de factory en aan een list toegevoegd met Nodes.
 * == Stap 3: Input 1 en eventueel input 2 toekennen per node
 * 
 * == Stap 4: Een done list & finished list wordt aangemaakt (leeg maar moeten nodes in kunnen).
 * Vervolgens wordt A, B & CIN afgehandeld. Hierdoor staat (volgens onze file) 1 & 2 in de "done" list.
 * Daarna blijft done afgehandeld worden tot alle in de "finished" list staan.
 * Cout & S zijn dan ingevuld & het proces is voltooid.
*/