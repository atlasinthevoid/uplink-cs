namespace Uplink.Entity
{
    public class FileSystem : Entity
    {
        public FileSystem()
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            _ = new Capability.Text() {Entity = Id, Name = "uplink data", Value = appData + @"\Uplink\" }.Id;
            _ = new Capability.Text() {Entity = Id, Name = "uplink ingest", Value = documents + @"\Uplink Ingest\" }.Id;
            _ = new Capability.Text() {Entity = Id, Name = "uplink export", Value = documents + @"\Uplink Export\" }.Id;
        }
    }
}
