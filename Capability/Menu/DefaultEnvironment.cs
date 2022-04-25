namespace Uplink.Capability.Menu
{
    public class DefaultEnvironment : Capability
    {

        public DefaultEnvironment()
        {
            StringType = "DefaultEnvironment";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}