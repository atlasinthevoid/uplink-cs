namespace Uplink.Capability.Core
{
    public class Pose : Capability
    {
        public StereoKit.Pose Value;

        public Pose()
        {
            StringType = "Pose";
            Value = new();
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            
        }
    }
}