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
        List<Node> list;
        Circuit circuit;
        Type[] typelist;
        public Factory()
        {
            list = new List<Node>();
            circuit = new Circuit();
            typelist = GetTypesInNamespace(Assembly.GetExecutingAssembly(), "Full_Adder.nodes");
        }
        private Type[] GetTypesInNamespace(Assembly assembly, string nameSpace)
        {
            return assembly.GetTypes().Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal)).ToArray();
        }
        public Node get(string className)
        {
            Node n = null;
            for (int i = 0; i < typelist.Length; i++)
            {
                if (typelist[i].Name == className)
                {
                    n = (Node)Activator.CreateInstance(typelist[i]);
                }
            }
            if(n == null)
            {
                throw new UnknownNodeTypeException();
            }
            return n;
        }
        public void generateNodes(List<string> lines, List<string> e)
        {
            foreach(String line in lines) {

                String[] parts = line.Replace(';', ' ').Split(':');
                String name = parts[0];
                String value = parts[1].Trim();
                try {
                    Node node = get(value);
                    node.Name = name;
                    list.Add(node);
                }
                catch (UnknownNodeTypeException ex) {
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }              
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
            circuit.startCircuit(list);
        }
        private Node getNodeByName(String name)
        {
            var matches = list.Find(p => p.Name == name);
            return matches;
        } 
    }
}
