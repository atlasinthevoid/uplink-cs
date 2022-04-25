namespace Uplink.Capability.Input
{
    public class Checkbox : Capability
    {

        public Checkbox()
        {
            StringType = "Checkbox";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}