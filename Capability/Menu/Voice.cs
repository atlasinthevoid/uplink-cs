namespace Uplink.Capability.Menu
{
    public class Voice : Capability
    {
        public Voice()
        {
            StringType = "Voice";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}