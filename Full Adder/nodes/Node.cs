using System.Collections.Generic;
namespace Full_Adder
{
    public class Node
    {
        private List<bool> inputs;

        public List<bool> Input
        {
            get { return inputs; }
            set { inputs = value; }
        }
        private List<Node> dependencies;
        public Node()
        {

        }
        public void addDependencie(Node node)
        {
            dependencies.Add(node);
        }
     
        public void addInput(bool input)
        {
            Input.Add(input);
        }
 
        public virtual bool execute()
        {
            return true;
        }


    }
}
