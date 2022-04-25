namespace Uplink.Capability.Media
{
    public class Sound : Capability
    {

        public Sound()
        {
            StringType = "Sound";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}