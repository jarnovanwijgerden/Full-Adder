using Full_Adder.nodes;
using System;
using System.Collections.Generic;
namespace Full_Adder
{
    public class Factory
    {
        List<Node> list;
        public Factory()
        {
            list = new List<Node>();
        }
        public Node get(string name)
        {
            switch (name)
            {
                case "INPUT_HIGH":
                    return new NodeInputHigh();
                case "INPUT_LOW":
                    return new NodeInputLow();
                case "PROBE":
                    return new Probe();
                case "OR":
                    return new NodeOR();
                case "AND":
                    return new NodeAnd();
                case "NOT":
                    return new NodeNot();
                case "NAND":
                    return new NodeNand();
                case "XOR":
                    return new NodeNor();
                case "NOR":
                    return new NodeNor();
                default:
                    Console.WriteLine("Naam is " + name);
                    throw new Exception();
            }
        }

        public void generateNodes(List<string> lines, List<string> edges)
        {
            foreach(String line in lines) {

                String[] parts = line.Replace(';', ' ').Split(':');
                String name = parts[0];
                String value = parts[1].Trim();


                Node node = get(value);
                node.Name = name;
                list.Add(node);
            }
            loopthroughlist();
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
