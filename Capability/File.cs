namespace Uplink.Capability
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
            Program.FileSystem.Register(this);
        }

        public override void Update()
        {
            
        }
    }
}