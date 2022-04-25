namespace Uplink.Capability.Input
{
    public class RatingControl : Capability
    {

        public RatingControl()
        {
            StringType = "RatingControl";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}