namespace Uplink.Capability.Style
{
    public class Gradient : Capability
    {
        public Gradient()
        {
            StringType = "Gradient";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}