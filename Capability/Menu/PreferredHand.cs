namespace Uplink.Capability.Menu
{
    public class PreferredHand : Capability
    {
        public PreferredHand()
        {
            StringType = "PreferredHand";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}