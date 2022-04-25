namespace Uplink.Capability.Menu
{
    public class Image : Capability
    {
        public List<byte> Bytes;

        public Image()
        {
            StringType = "Image";
            Bytes = new();
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            
        }
    }
}