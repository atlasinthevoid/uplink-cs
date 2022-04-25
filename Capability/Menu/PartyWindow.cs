namespace Uplink.Capability.Menu
{
    public class PartyWindow : Capability
    {
        public PartyWindow()
        {
            StringType = "PartyWindow";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}