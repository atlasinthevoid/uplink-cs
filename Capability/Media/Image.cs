namespace Uplink.Capability.Media
{
    public class Image : Capability
    {

        public Image()
        {
            StringType = "Image";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}