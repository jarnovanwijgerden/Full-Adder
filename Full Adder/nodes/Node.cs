using Full_Adder.observer;
using Full_Adder.patterns;
using System;
using System.Collections.Generic;

namespace Full_Adder.nodes
{
    public class Node : Strategy, IObserver, IObservable
    {
        private string name;
        private string extraInfo;
        private int inputcount;

        private List<bool> inputs = new List<bool>();
        private List<Node> dependencies = new List<Node>();
        public List<Node> Dependencies
        {
            get { return dependencies; }
            set { dependencies = value; }
        }
        public string ExtraInfo
        {
            get { return extraInfo; }
            set { extraInfo = value; }
        }
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
      
        public void Notify(bool value)
        {
            this.inputs.Add(Convert.ToBoolean(value));
            if (inputcount == inputs.Count)
            {
                bool val = this.execute();
                Console.WriteLine("Node {0} is een {1} en heeft uitkomst {2} ", this.Name, this.ExtraInfo, val);
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
        public override bool execute()
        {
            throw new NotImplementedException();
        }

        public override bool result()
        {
            throw new NotImplementedException();
        }
    }
}
