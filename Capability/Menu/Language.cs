namespace Uplink.Capability.Menu
{
    public class Language : Capability
    {

        public Language()
        {
            StringType = "Language";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}