namespace Uplink.Capability
{
    public class Audio : Capability
    {
        public List<byte> Bytes;

        public Audio()
        {
            Bytes = new();
        }

        public override void Update()
        {

        }
    }
}