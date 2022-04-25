namespace Uplink.Capability.World
{
    public class Audio : Capability
    {
        public List<byte> Bytes;

        public Audio()
        {
            StringType = "Audio";
            Bytes = new();
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}