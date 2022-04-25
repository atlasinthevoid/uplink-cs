namespace Uplink.Capability.World
{
    public class Painter : Capability
    {
        public Painter()
        {
            StringType = "Painter";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}