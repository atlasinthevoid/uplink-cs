namespace Uplink.Capability.Layout
{
    public class DataGrid : Capability
    {

        public DataGrid()
        {
            StringType = "DataGrid";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}