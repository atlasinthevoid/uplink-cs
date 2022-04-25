namespace Uplink.Capability.Menu
{
    public class Clock : Capability
    {

        public Clock()
        {
            StringType = "Clock";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}