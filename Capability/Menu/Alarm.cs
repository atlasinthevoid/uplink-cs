namespace Uplink.Capability.Menu
{
    public class Alarm : Capability
    {
        public Alarm()
        {
            StringType = "Alarm";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}