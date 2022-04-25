namespace Uplink.Capability.Menu
{
    public class ExtenalNetwork : Capability
    {

        public ExtenalNetwork()
        {
            StringType = "ExtenalNetwork";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}