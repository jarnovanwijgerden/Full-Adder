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
        //Overschrijven van de methode (Strategy pattern)
        //Wanneer er geen input binnen is gekomen bij de probe, zal er een exception optreden
        public override bool result()
        {
            if(Input.Count == 0)
            {
                throw new UnconnectedPinsException();
            }
            return Input[0];
        }
        //Overschrijven van de methode (Strategy pattern)
        public override bool execute()
        {
            return Input[0];
        }
    }
}
