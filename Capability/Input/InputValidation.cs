namespace Uplink.Capability.Input
{
    public class InputValidation : Capability
    {

        public InputValidation()
        {
            StringType = "InputValidation";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}