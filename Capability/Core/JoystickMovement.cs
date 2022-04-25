namespace Uplink.Capability.Core
{
    public class JoystickMovement : Capability
    {

        public JoystickMovement()
        {
            StringType = "JoystickMovement";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}