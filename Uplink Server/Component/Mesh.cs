namespace Uplink.Component
{
    public class Mesh : Component
    {
        public byte[] Bytes
        {
            get;
            init;
        }

        public Mesh()
        {
            Bytes = new byte[4];
        }

        public override void Update()
        {
            
        }
    }
}