namespace Uplink.Capability.Navigation
{
    public class Pivot : Capability
    {
        public Pivot()
        {
            StringType = "Pivot";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}