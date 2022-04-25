namespace Uplink.Capability.Layout
{
    public class Grid : Capability
    {

        public Grid()
        {
            StringType = "Grid";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}