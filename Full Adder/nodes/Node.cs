using System.Collections.Generic;
namespace Full_Adder
{
    public class Node
    {
        private List<bool> inputs;

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
            inputs.Add(input);
        }
 
        public virtual bool execute()
        {
            return true;
        }


    }
}
