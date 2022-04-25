namespace Uplink.Capability.Menu
{
    public class Handle : Capability
    {

        public Handle()
        {
            StringType = "Handle";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}