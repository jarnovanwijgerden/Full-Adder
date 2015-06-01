using Full_Adder.observer;
using System;
using System.Collections.Generic;
namespace Full_Adder
{
    public class Node : IObserver, IObservable
    {
        private string name;
        private List<bool> inputs = new List<bool>();
        private List<Node> dependencies = new List<Node>();

        public List<Node> Dependencies
        {
            get { return dependencies; }
            set { dependencies = value; }
        }
        private int inputcount;
        public int Inputcount
        {
            get { return inputcount; }
            set { inputcount = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<bool> Input
        {
            get { return inputs; }
            set { inputs = value; }
        }
        public void addInput(bool input)
        {
            Input.Add(input);
            if (inputcount == inputs.Count)
            {
                bool val = this.execute();
                NotifyObservers(val);
            }
        }
        public virtual bool execute()
        {
            Console.WriteLine("Error @ {0}", Name);
            throw new NotImplementedException();
        }
        public virtual bool result()
        {
            throw new NotImplementedException();
        }
        public void Notify(bool value)
        {
            this.inputs.Add(Convert.ToBoolean(value));
            if (inputcount == inputs.Count)
            {
                bool val = this.execute();
                Console.WriteLine("Node {0} uitgevoerd, uitkomst {1 } ", this.Name, val);
                NotifyObservers(val);
            }
            
        }
        public void Register(Node node)
        {
            dependencies.Add(node);
        }
        public void UnRegister(Node node)
        {
            dependencies.Remove(node);
        }
        public void NotifyObservers(bool value)
        {
            foreach(Node n in dependencies) {
                n.Notify(value);
            }
        }
    }
}
