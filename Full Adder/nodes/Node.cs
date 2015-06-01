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
        }
        public virtual bool execute()
        {
            return true;
        }
        public void Notify(bool value)
        {
            this.inputs.Add(Convert.ToBoolean(value));
            if (dependencies.Count == inputs.Count)
            {
                bool val = this.execute();
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
