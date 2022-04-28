namespace Uplink.Capability.Menu
{
    public class Window : Capability
    {
        public string Title;

        public Window()
        {
            StringType = "Window";
            Title = "";
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            if (Metadata.ContainsKey("Parent") && Metadata.Get("Parent").Value.Capabilities.ContainsType("Pose"))
            {
                StereoKit.Pose p = Metadata.Get("Parent").Value.Capabilities.ByType("Pose")[0].Value;
                StereoKit.UI.WindowBegin(Title, ref p);
                foreach (Capability c in Metadata.Get("Parent").Value.Capabilities.Get())
                {
                    c.WindowUpdate();
                }
            }
            StereoKit.UI.WindowEnd();
        }
    }
}