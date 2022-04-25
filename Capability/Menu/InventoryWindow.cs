namespace Uplink.Capability.Menu
{
    public class InventoryWindow : Capability
    {

        public InventoryWindow()
        {
            StringType = "InventoryWindow";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}