namespace Uplink
{
    public class AudioComponent : Component
    {
        public byte[] Bytes;

        public AudioComponent()
        {
            Bytes = new byte[800];
        }
        public AudioComponent(Guid author, string name, byte[] bytes) : base(author, name)
        {
            Bytes = bytes;
        }
    }
}