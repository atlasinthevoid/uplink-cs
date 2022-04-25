namespace Uplink.Capability.Menu
{
    public class Calendar : Capability
    {

        public Calendar()
        {
            StringType = "Calendar";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}