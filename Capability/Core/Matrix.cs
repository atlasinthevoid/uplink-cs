namespace Uplink.Capability.Core
{
    public class Matrix : Capability
    {
        public StereoKit.Matrix Value;

        public Matrix()
        {
            StringType = "Matrix";
            Value = new();
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            
        }
    }
}