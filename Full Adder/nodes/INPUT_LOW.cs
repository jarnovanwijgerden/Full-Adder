namespace Full_Adder.nodes
{
    class INPUT_LOW : Node
    {
        public INPUT_LOW()
        {
            this.Inputcount = 1;
        }
        //Overschrijven van de methode (Strategy pattern)
        public override bool execute()
        {
            return false;
        }
    }
}
