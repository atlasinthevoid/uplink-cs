namespace Uplink.Capability
{
    public class Matrix : Capability
    {
        public StereoKit.Matrix Value;

        public Matrix()
        {
            StringType = "Matrix";
            Value = new();
            Program.MatrixSystem.Register(this);
        }

        public override void Update()
        {
            
        }
    }
}