namespace Uplink
{
    public class ImageComponent : Component
    {
        public byte[] Bytes;

        public ImageComponent()
        {
            Bytes = new byte[800];
        }

        public ImageComponent(Guid author, string name, byte[] bytes) : base(author, name)
        {
            Bytes = bytes;
        }
    }
}