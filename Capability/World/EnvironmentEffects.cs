namespace Uplink.Capability.World
{
    public class EnvironmentEffects : Capability
    {

        public EnvironmentEffects()
        {
            StringType = "EnvironmentEffects";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}