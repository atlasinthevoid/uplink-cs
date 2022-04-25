namespace Uplink.Capability.Text
{
    public class AudoSuggestBox : Capability
    {
        public AudoSuggestBox()
        {
            StringType = "AudoSuggestBox";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}