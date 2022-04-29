namespace Uplink.Capability.World
{
    public class FBX : Capability
    {
        public bool Rendered;
        public string Path;

        public FBX()
        {
            StringType = "FBX";
            Rendered = false;
            Path = "";
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            if (!Rendered)
            {
                
            }
        }
    }
}