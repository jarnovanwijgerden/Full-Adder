namespace Full_Adder.nodes
{
    public class NOR : Node
    {
        public NOR()
        {
            this.Inputcount = 2;
            this.ExtraInfo = "NOR";
        }
        public override bool execute()
        {
            return (this.Input[0] == false && this.Input[1] == false);
        }
    }
}
