namespace Uplink.Capability.Core
{
    public class FileSystem : Capability
    {
        bool Setup;

        public FileSystem()
        {
            Setup = false;
        }

        public override void Update()
        {
            if (Metadata.ContainsKey("Parent") && !Setup)
            {
                Type.Entity p = Metadata.Get("Parent");
                string appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                Text uData = new();
                uData.Metadata.Add(new Type.Name() { Value = "uplink data" });
                uData.Value = appData + @"\Uplink\";
                p.Add(uData);

                Text uIngest = new();
                uIngest.Metadata.Add(new Type.Name { Value = "uplink ingest" });
                uIngest.Value = documents + @"\Uplink Ingest\";
                p.Add(uIngest);

                Text uExport = new();
                uExport.Metadata.Add(new Type.Name { Value = "uplink export" });
                uExport.Value = documents + @"\Uplink Export\";
                p.Add(uExport);

                Setup = true;
            }
        }
    }
}
