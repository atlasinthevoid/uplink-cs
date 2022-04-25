namespace Uplink.Capability.Layout
{
    public class Expander : Capability
    {

        public Expander()
        {
            StringType = "Expander";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}