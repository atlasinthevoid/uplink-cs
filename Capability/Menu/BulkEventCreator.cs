namespace Uplink.Capability.Menu
{
    public class BulkEventCreator : Capability
    {
        public BulkEventCreator()
        {
            StringType = "BulkEventCreator";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}