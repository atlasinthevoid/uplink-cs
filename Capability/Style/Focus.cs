namespace Uplink.Capability.Style
{
    public class Focus : Capability
    {
        public Focus()
        {
            StringType = "Focus";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}