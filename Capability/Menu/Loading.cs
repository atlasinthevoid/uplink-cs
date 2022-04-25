namespace Uplink.Capability.Menu
{
    public class Loading : Capability
    {
        public Loading()
        {
            StringType = "Loading";
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            
        }
    }
}