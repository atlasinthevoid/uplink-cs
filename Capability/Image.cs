namespace Uplink.Capability
{
    public class Image : Capability
    {
        public List<byte> Bytes;

        public Image()
        {
            StringType = "Image";
            Bytes = new();
            Program.ImageSystem.Register(this);
        }

        public override void Update()
        {
            
        }
    }
}