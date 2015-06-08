using Full_Adder.observer;
using Full_Adder.patterns;
using System;
using System.Collections.Generic;

namespace Full_Adder.nodes
{
    //Deze classe is afgeleid van Strategy, IObserver en IObservable
    public class Node : Strategy, IObserver, IObservable
    {
        //private fields maken
        private string name;
        private string extraInfo;
        private int inputcount;

        //lijst voor de inputs die de node nodig heeft voor het kunnen uitvoerren
        private List<bool> inputs = new List<bool>();
        //lijst met nodes die afhankelijk zijn van deze node
        private List<Node> dependencies = new List<Node>();

        //Getters en Setters aanmaken
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
        //Methode voor het invoeren van een input
        public void addInput(bool input)
        {
            //Input toevoegen
            Input.Add(input);
            //Controleren of er evenveel inputs zijn dan er nodig zijn
            if (inputcount == inputs.Count)
            {
                //zo ja laten uitvoeren van de taak
                bool val = this.execute();
                //Dependecies laten weten
                NotifyObservers(val);
            }
        }
        //Methode voor het ontvangen van een input
        public void Notify(bool value)
        {
            //input toevoegen
            this.inputs.Add(Convert.ToBoolean(value));
            //Controleren of er evenveel inputs zijn dan er nodig zijn
            if (inputcount == inputs.Count)
            {
                bool val = this.execute();
                //zo ja laten uitvoeren van de taak
                Console.WriteLine("Node {0} is een {1} en heeft uitkomst {2} ", this.Name, this.ExtraInfo, val);
                //Dependecies laten weten
                NotifyObservers(val);
            }
            
        }
        //Afhankelijke node toevoegen
        public void Register(Node node)
        {
            dependencies.Add(node);
        }
        //Afhankelijke node verwijderen
        public void UnRegister(Node node)
        {
            dependencies.Remove(node);
        }
        //Methode voor het laten weten van de afhankelijk nodes
        public void NotifyObservers(bool value)
        {
            //Voor elke afhankelijke node, input toevoege
            foreach(Node n in dependencies) {
                n.Notify(value);
            }
        }
        //Strategy pattern
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
