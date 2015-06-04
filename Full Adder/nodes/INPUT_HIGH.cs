namespace Full_Adder.nodes
{
    class INPUT_HIGH : Node
    {
        public INPUT_HIGH()
        {
            this.Inputcount = 1;
        }
        public override bool execute()
        {
            return true;
        }
    }
}
