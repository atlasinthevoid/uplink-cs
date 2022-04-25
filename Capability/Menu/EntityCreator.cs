namespace Uplink.Capability.Menu
{
    public class EntityCreator : Capability
    {

        public EntityCreator()
        {
            StringType = "EntityCreator";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}