using Full_Adder.exception;
namespace Full_Adder.nodes
{
    class PROBE : Node
    {
        public PROBE()
        {
            this.Inputcount = 1;
            this.ExtraInfo = "PROBE";
        }
        public override bool result()
        {
            if(Input.Count == 0)
            {
                throw new UnconnectedPinsException();
            }
            return Input[0];
        }
        public override bool execute()
        {
            return Input[0];
        }
    }
}
