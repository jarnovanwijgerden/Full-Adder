using Full_Adder.nodes;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using Full_Adder.exception;

namespace Full_Adder
{
    public class Factory
    {
        
        //Variables aanmaken
        private List<Node> list;
        private Circuit circuit;
        private Type[] typelist;
        public Factory()
        {
            //Nieuwe instanties maken van variablen
            list = new List<Node>();
            circuit = new Circuit();
            //Alle Types in namespace ophalen
            typelist = GetTypesInNamespace(Assembly.GetExecutingAssembly(), "Full_Adder.nodes");
        }
        //Methodes voor alle types in een namespace ophalen
        private Type[] GetTypesInNamespace(Assembly assembly, string nameSpace)
        {
            //Alle types ophalen die aan de condities voldoen (Juiste namespace)
            return assembly.GetTypes().Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal)).ToArray();
        }
        //Methode ophalen van juiste node type
        public Node get(string className)
        {
            Node n = null;
            //Loopen door alle type nodes
            for (int i = 0; i < typelist.Length; i++)
            {
                //Controleren of node type gelijk is de node die we zoeken
                if (typelist[i].Name == className)
                {
                    //nieuwe instantie terug geven
                    n = (Node)Activator.CreateInstance(typelist[i]);
                }
            }
            //controleren of node instantie gevuld is.
            if(n == null)
            {
                //Exception gooien voor onbekende node type
                throw new UnknownNodeTypeException();
            }
            return n;
        }
        public void generateNodes(List<string> lines, List<string> e)
        {
            //Door elke nodeline loopen
            foreach(String line in lines) {

                //deze splitsen op de : 
                //Bijv : S:	INPUT_HIGH; zodat je de naam weet v/d node en het type 
                String[] parts = line.Replace(';', ' ').Split(':');
                String name = parts[0];
                String value = parts[1].Trim();
                try {
                    //Node instantie ophalen aan de hand van node type
                    Node node = get(value);
                    node.Name = name;
                    //Toevoegen aan de lijst met nodes
                    list.Add(node);
                }
                //Exception opvangen en programma afsluiten
                catch (UnknownNodeTypeException ex) {
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }              
            }
            //Methode voor het binden van afhankelijke nodes
            bindNodes(e);
        }
        private void bindNodes(List<string> edges)
        {
            //Door elke node edge loopen
            foreach (String line in edges)
            {
                //deze splitsen op de : 
                //Bijv : NODE1:	NODE3,NODE5; 
                //NODE3 en NODE5 zijn afhankelijk van NODE1 zijn uitkomst
                String[] parts = line.Replace(';', ' ').Split(':');
                Node node = getNodeByName(parts[0]);
                String[] dependencies = parts[1].Trim().Split(',');

                //door elke lijst met afhankelijkheden lopen
                foreach (String dep in dependencies)
                {
                    //Afhankelijk node ophalen
                    Node d = getNodeByName(dep);
                    //Afhankelijke node registeren
                    node.Register(d);
                }
            }
            //Circuit starten
            circuit.startCircuit(list);
        }
        //Methode voor het vinden van een node aan de hand van de naam
        private Node getNodeByName(String name)
        {
            var matches = list.Find(p => p.Name == name);
            return matches;
        } 
    }
}
