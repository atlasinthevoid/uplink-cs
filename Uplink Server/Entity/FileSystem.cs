namespace Uplink.Entity
{
    public class FileSystem : Entity
    {
        public FileSystem()
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            Capability.Text uData = new();
            uData.Metadata.Add(new Type.Name() { Value = "uplink data" });
            uData.Value = appData + @"\Uplink\";
            Add(uData);

            Capability.Text uIngest = new();
            uIngest.Metadata.Add(new Type.Name { Value = "uplink ingest" });
            uIngest.Value = documents + @"\Uplink Ingest\";
            Add(uIngest);

            Capability.Text uExport = new();
            uExport.Metadata.Add(new Type.Name { Value = "uplink export" });
            uExport.Value = documents + @"\Uplink Export\";
            Add(uExport);
        }
    }
}
