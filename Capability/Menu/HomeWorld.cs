namespace Uplink.Capability.Menu
{
    public class HomeWorld : Capability
    {

        public HomeWorld()
        {
            StringType = "HomeWorld";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}