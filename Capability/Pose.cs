namespace Uplink.Capability
{
    public class Pose : Capability
    {
        public StereoKit.Pose Value;

        public Pose()
        {
            StringType = "Pose";
            Value = new();
            Program.PoseSystem.Register(this);
        }

        public override void Update()
        {
            
        }
    }
}