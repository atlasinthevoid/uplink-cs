namespace Uplink.Capability.Menu
{
    public class SpellChecker : Capability
    {
        public SpellChecker()
        {
            StringType = "SpellChecker";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}