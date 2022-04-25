namespace Uplink.Capability.Input
{
    public class Combobox : Capability
    {

        public Combobox()
        {
            StringType = "Combobox";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}