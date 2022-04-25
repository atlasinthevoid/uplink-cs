namespace Uplink.Capability.Menu
{
    public class RebootButton : Capability
    {
        public RebootButton()
        {
            StringType = "RebootButton";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}