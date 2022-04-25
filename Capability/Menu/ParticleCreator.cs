namespace Uplink.Capability.Menu
{
    public class ParticleCreator : Capability
    {
        public ParticleCreator()
        {
            StringType = "ParticleCreator";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}