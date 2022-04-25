namespace Uplink.Capability.Menu
{
    public class RunInBackground : Capability
    {
        public RunInBackground()
        {
            StringType = "RunInBackground";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}