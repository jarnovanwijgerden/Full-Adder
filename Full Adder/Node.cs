namespace Full_Adder
{
    public class Node
    {
        private bool[] input;
        private int ingangs;

        public Node(int ingang)
        {
            ingangs = ingang;
        }

        public bool[] Input
        {
            get { return input; }
            set { input = value; }
        }

        public virtual bool execute();


    }
}
