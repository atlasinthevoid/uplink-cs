namespace Uplink.Capability.Core
{
    public class Inventory : Capability
    {
        public List<Type.Entity> Items;

        public Inventory()
        {
            StringType = "Int";
            Items = new();
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}