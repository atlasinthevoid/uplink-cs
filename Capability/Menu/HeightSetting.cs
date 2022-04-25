namespace Uplink.Capability.Menu
{
    public class HeightSetting : Capability
    {

        public HeightSetting()
        {
            StringType = "HeightSetting";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}