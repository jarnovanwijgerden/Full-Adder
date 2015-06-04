namespace Full_Adder.nodes
{
    public class NAND : Node
    {
        public NAND()
        {
            this.Inputcount = 2;
            this.ExtraInfo = "NAND";
        }
        public override bool execute()
        {
            if(this.Input[0] == this.Input[1] && this.Input[1] == false || this.Input[0] != this.Input[1])
            {
                return true;
            }
            return false;
        }
    }
}
