namespace Uplink.Capability.Text
{
    public class NumberBox : Capability
    {
        public NumberBox()
        {
            StringType = "NumberBox";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}