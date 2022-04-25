namespace Uplink.Capability.StatusBar
{
    public class Infobar : Capability
    {
        public Infobar()
        {
            StringType = "Infobar";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}