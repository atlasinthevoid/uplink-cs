namespace Uplink.Capability.Menu
{
    public class UIToolKit : Capability
    {
        public UIToolKit()
        {
            StringType = "UIToolKit";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}