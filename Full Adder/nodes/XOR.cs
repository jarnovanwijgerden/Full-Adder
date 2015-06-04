namespace Full_Adder.nodes
{
    public class XOR : Node
    {
        public XOR()
        {
            this.Inputcount = 2;
            this.ExtraInfo = "XOR";
        }
        public override bool execute()
        {
            return this.Input[0] != this.Input[1];
        }
    }
}
