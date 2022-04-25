namespace Uplink.Capability.Menu
{
    public class GraphicalC : Capability
    {

        public GraphicalC()
        {
            StringType = "GraphicalC";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}