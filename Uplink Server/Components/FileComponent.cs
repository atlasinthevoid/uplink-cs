namespace Uplink
{
    public class FileComponent : Component
    {
        public byte[] Bytes;
        public string filePath;

        public FileComponent()
        {
            Bytes = new byte[0];
            filePath = "";
        }

        public FileComponent(Guid author, string name, byte[] bytes, string path) : base(author, name)
        {
            Bytes = bytes;
            filePath = path;
        }
    }
}