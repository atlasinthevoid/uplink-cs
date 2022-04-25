namespace Uplink.Capability.Style
{
    public class Arylic : Capability
    {
        public Arylic()
        {
            StringType = "Arylic";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}