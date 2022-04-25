namespace Uplink.Capability.Core
{
    public class ExpressionSystem : Capability
    {

        public ExpressionSystem()
        {
            StringType = "ExpressionSystem";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}