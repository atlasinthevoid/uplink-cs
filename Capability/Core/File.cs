namespace Uplink.Capability.Core
{
    public class File : Capability
    {
        public List<byte> Bytes;

        public string FilePath;

        public File()
        {
            StringType = "File";
            Bytes = new();
            FilePath = "";
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            
        }
    }
}