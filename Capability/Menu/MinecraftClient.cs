namespace Uplink.Capability.Menu
{
    public class MinecraftClient : Capability
    {

        public MinecraftClient()
        {
            StringType = "MinecraftClient";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}