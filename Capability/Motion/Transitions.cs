namespace Uplink.Capability.Motion
{
    public class Transitions : Capability
    {
        public Transitions()
        {
            StringType = "Transitions";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}