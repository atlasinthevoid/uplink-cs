namespace Uplink.Capability.Menu
{
    public class EventCreator : Capability
    {

        public EventCreator()
        {
            StringType = "EventCreator";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}