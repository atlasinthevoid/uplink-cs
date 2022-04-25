namespace Uplink.Capability.Layout
{
    public class ItemsRepeater : Capability
    {

        public ItemsRepeater()
        {
            StringType = "ItemsRepeater";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}