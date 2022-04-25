namespace Uplink.Capability.Menu
{
    public class TeamViewerClient : Capability
    {
        public TeamViewerClient()
        {
            StringType = "TeamViewerClient";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}