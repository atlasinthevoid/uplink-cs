namespace Uplink.Capability.Layout
{
    public class Canvas : Capability
    {

        public Canvas()
        {
            StringType = "Canvas";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}