namespace Uplink.Capability.Layout
{
    public class VariableSizedWrapGrip : Capability
    {

        public VariableSizedWrapGrip()
        {
            StringType = "VariableSizedWrapGrip";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}