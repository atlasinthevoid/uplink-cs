namespace Uplink.Type
{
    public class Id
    {
        private System.Guid id;

        public Id()
        {
            guid = System.Guid.NewGuid();
        }

        public string ShortGuid()
        {
            return id.ToString().Split("-")[0];
        }
    }
}
