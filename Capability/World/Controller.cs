namespace Uplink.Capability.World
{
    public class Controller : Capability
    {

        public Controller()
        {
            StringType = "Controller";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}