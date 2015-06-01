using Full_Adder.nodes;
using System;
using System.Collections.Generic;
namespace Full_Adder
{
    public class Factory
    {
        List<Node> list;
        Circuit circuit;
        public Factory()
        {
            list = new List<Node>();
           
        }
        public Node get(string name)
        {
            Node n;
            switch (name)
            {
                case "INPUT_HIGH":
                    n = new NodeInputHigh();
                    n.Inputcount = 1;
                    return n;
                case "INPUT_LOW":
                    n = new NodeInputLow();
                    n.Inputcount = 1;
                    return n;
                case "PROBE":
                    n = new Probe();
                    n.Inputcount = 1;
                    return n;
                case "OR":
                    n = new NodeOR();
                    n.Inputcount = 2;
                    return n;
                case "AND":
                    n = new NodeAnd();
                    n.Inputcount = 2;
                    return n;
                case "NOT":
                    n = new NodeNot();
                    n.Inputcount = 1;
                    return n;
                case "NAND":
                    n = new NodeNand();
                    n.Inputcount = 2;
                    return n;
                case "XOR":
                    n = new NodeXor();
                    n.Inputcount = 2;
                    return n;
                case "NOR":
                    n = new NodeNor();
                    n.Inputcount = 2;
                    return n;
                default:
                    Console.WriteLine("Naam is " + name);
                    throw new Exception();
            }
        }
        public void generateNodes(List<string> lines, List<string> e)
        {
            foreach(String line in lines) {

                String[] parts = line.Replace(';', ' ').Split(':');
                String name = parts[0];
                String value = parts[1].Trim();

                Node node = get(value);
                node.Name = name;
                list.Add(node);
            }
            bindNodes(e);
        
        }

        private void bindNodes(List<string> edges)
        {
            foreach (String line in edges)
            {
                String[] parts = line.Replace(';', ' ').Split(':');
                Node node = getNodeByName(parts[0]);
                String[] dependencies = parts[1].Trim().Split(',');

                foreach (String dep in dependencies)
                {
                    Node d = getNodeByName(dep);
                    node.Register(d);
                }
            }
            circuit = new Circuit(list);
        }

        private Node getNodeByName(String name)
        {
            var matches = list.Find(p => p.Name == name);
            return matches;
        }

        public void loopthroughlist()
        {
            foreach(Node n in list)
            {
                Console.WriteLine(n.Name + " | " + n.GetType());
            }
        }
    
    }
}
