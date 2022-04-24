namespace Uplink.Capability
{
    public class Handle : Capability
    {

        public Handle()
        {
            StringType = "Handle";
            Program.HandleSystem.Register(this);
        }

        public override void Update()
        {

        }
    }
}