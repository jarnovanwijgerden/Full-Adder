namespace Full_Adder.nodes
{
    public class OR : Node
    {
        public OR()
        {
            this.Inputcount = 2;
            this.ExtraInfo = "OR";
        }
        //Overschrijven van de methode (Strategy pattern)
        public override bool execute()
        {
            return (this.Input[0] == true || this.Input[1] == true);
        }
    }
}
