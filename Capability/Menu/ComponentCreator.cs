namespace Uplink.Capability.Menu
{
    public class ComponentCreator : Capability
    {

        public ComponentCreator()
        {
            StringType = "ComponentCreator";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}