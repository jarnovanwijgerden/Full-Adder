namespace Full_Adder
{
    public class NodeXor : Node
    {
        public override bool execute()
        {
            return this.Input[0] != this.Input[1];
        }
    }
}
