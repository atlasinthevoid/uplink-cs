namespace Uplink.Type
{
    public class Id
    {
        private System.Guid id;

        public Id(bool empty = false)
        {
            if (empty)
            {
                this.id = Guid.Empty;
            } else {
                id = System.Guid.NewGuid();
            }
        }

        public string ShortGuid()
        {
            return id.ToString().Split("-")[0];
        }
    }
}
