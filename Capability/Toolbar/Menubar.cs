namespace Uplink.Capability.Toolbar
{
    public class Menubar : Capability
    {
        public Menubar()
        {
            StringType = "Menubar";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}