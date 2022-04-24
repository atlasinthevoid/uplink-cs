namespace Uplink.Capability
{
    public class Inventory : Capability
    {
        public List<Entity.Entity> Items;

        public Inventory()
        {
            StringType = "Int";
            Items = new();
            Program.InventorySystem.Register(this);
        }

        public override void Update()
        {

        }
    }
}