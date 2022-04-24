namespace Uplink.Capability
{
    public class Loading : Capability
    {
        public Loading()
        {
            StringType = "Loading";
            Program.LoadingSystem.Register(this);
        }

        public override void Update()
        {
            
        }
    }
}