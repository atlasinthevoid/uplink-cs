namespace Uplink.Type
{
    public class Id : Type
    {
        private System.Guid id;

        public Id()
        {
            StringType = "Id";
            id = System.Guid.NewGuid();
        }

        public Id(bool empty = false)
        {
            StringType = "Id";
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
