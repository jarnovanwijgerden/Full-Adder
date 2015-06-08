namespace Full_Adder.nodes
{
    public class AND : Node
    {
        public AND()
        {
            this.Inputcount = 2;
            this.ExtraInfo = "AND";
        }
        //Overschrijven van de methode (Strategy pattern)
        public override bool execute()
        {
            return this.Input[0] == this.Input[1];
        }
    }
}
