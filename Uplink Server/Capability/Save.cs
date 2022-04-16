using System.Xml.Serialization;

namespace Uplink.Capability
{
    public class Save : Capability
    {
        public bool SaveToFile
        {
            get;
            init;
        }

        public Save()
        {
            
        }

        public override void Update()
        {
            Environment.Exit(0);
            if (SaveToFile)
            {
                //SaveToFile = false;
                SaveUniverseToFile(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Uplink\");
                Environment.Exit(0);
            }
        }
    }
}