namespace Uplink
{
    public class MeshComponent : Component
    {
        public byte[] Bytes
        {
            get;
            init;
        }

        public MeshComponent()
        {
            Bytes = new byte[4];
        }

        public override void Update()
        {
            
        }
    }
}