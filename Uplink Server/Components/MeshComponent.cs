namespace Uplink
{
    public class MeshComponent : Component
    {
        public byte[] Bytes;

        public MeshComponent()
        {
            Bytes = new byte[4];
        }

        public MeshComponent(Guid author, string name, byte[] bytes) : base(author, name)
        {
            Bytes = bytes;
        }
    }
}