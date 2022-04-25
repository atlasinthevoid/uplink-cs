namespace Uplink.Capability.Menu
{
    public class Mouse : Capability
    {

        public Mouse()
        {
            StringType = "Mouse";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}