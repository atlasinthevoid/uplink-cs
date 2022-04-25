namespace Uplink.Capability.Menu
{
    public class MusicVolume : Capability
    {

        public MusicVolume()
        {
            StringType = "MusicVolume";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}