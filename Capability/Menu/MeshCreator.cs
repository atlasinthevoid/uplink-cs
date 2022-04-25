namespace Uplink.Capability.Menu
{
    public class MeshCreator : Capability
    {

        public MeshCreator()
        {
            StringType = "MeshCreator";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}