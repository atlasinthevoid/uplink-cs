namespace Uplink.Capability.Menu
{
    public class Keyboard : Capability
    {

        public Keyboard()
        {
            StringType = "Keyboard";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}