namespace Uplink.Capability.Core
{
    public class FileSystem : Capability
    {
        bool Setup;

        public FileSystem()
        {
            StringType = "FileSystem";
            Setup = false;
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            if (Metadata.ContainsKey("Parent") && !Setup)
            {
                Type.Entity p = Metadata.Get("Parent").Value;
                string appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                Text uData = new();
                uData.Metadata.Add(new Type.Name() { Value = "uplink data" });
                uData.Value = appData + @"\Uplink\";
                p.Add(uData);
                System.IO.Directory.CreateDirectory(appData + @"\Uplink\");

                Text uIngest = new();
                uIngest.Metadata.Add(new Type.Name { Value = "uplink ingest" });
                uIngest.Value = documents + @"\Uplink Ingest\";
                p.Add(uIngest);
                System.IO.Directory.CreateDirectory(documents + @"\Uplink Ingest\");

                Text uExport = new();
                uExport.Metadata.Add(new Type.Name { Value = "uplink export" });
                uExport.Value = documents + @"\Uplink Export\";
                p.Add(uExport);
                System.IO.Directory.CreateDirectory(documents + @"\Uplink Export\");

                Setup = true;
            }
        }
    }
}
