namespace Uplink.Capability.Menu
{
    public class CodeEditor : Capability
    {

        public CodeEditor()
        {
            StringType = "CodeEditor";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}