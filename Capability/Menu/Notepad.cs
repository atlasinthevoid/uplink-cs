namespace Uplink.Capability.Menu
{
    public class Notepad : Capability
    {

        public Notepad()
        {
            StringType = "Notepad";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}