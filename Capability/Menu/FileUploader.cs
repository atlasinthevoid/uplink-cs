namespace Uplink.Capability.Menu
{
    public class FileUploader : Capability
    {

        public FileUploader()
        {
            StringType = "FileUploader";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}