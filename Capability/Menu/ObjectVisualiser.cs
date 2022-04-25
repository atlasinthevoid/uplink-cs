namespace Uplink.Capability.Menu
{
    public class ObjectVisualiser : Capability
    {
        public ObjectVisualiser()
        {
            StringType = "ObjectVisualiser";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}