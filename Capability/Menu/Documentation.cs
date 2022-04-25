namespace Uplink.Capability.Menu
{
    public class Documentation : Capability
    {

        public Documentation()
        {
            StringType = "Documentation";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}