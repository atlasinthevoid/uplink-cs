namespace Uplink.Capability
{
    public class Mesh : Capability
    {
        public byte[] Bytes
        {
            get;
            init;
        }

        public Mesh()
        {
            Bytes = new byte[4];
            Program.MeshSystem.Register(this);
        }

        public override void Update()
        {
            
        }
    }
}