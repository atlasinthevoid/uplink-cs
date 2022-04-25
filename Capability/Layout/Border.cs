namespace Uplink.Capability.Layout
{
    public class Border : Capability
    {

        public Border()
        {
            StringType = "Border";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}