namespace Uplink.Capability
{
    public class Controller : Capability
    {

        public Controller()
        {
            StringType = "Controller";
            Program.ControllerSystem.Register(this);
        }

        public override void Update()
        {

        }
    }
}