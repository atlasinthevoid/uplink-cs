namespace Uplink.Capability.Menu
{
    public class MediaControls : Capability
    {

        public MediaControls()
        {
            StringType = "MediaControls";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}