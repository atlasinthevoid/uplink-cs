namespace Uplink.Capability.World
{
    public class SpawnableObjectsList : Capability
    {
        public SpawnableObjectsList()
        {
            StringType = "SpawnableObjectsList";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}