namespace Uplink.Capability.Menu
{
    public class Rules : Capability
    {
        public Rules()
        {
            StringType = "Rules";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}