namespace Uplink.Capability.Layout
{
    public class ListView : Capability
    {

        public ListView()
        {
            StringType = "ListView";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}