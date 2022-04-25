namespace Uplink.Capability.Menu
{
    public class Antialising : Capability
    {
        public Antialising()
        {
            StringType = "Antialising";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}