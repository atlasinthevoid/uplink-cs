namespace Uplink.Capability.Menu
{
    public class Window : Capability
    {
        public string Title;
        public bool UpdateStarted;

        public Window()
        {
            StringType = "Window";
            Title = "";
            UpdateStarted = false;
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            if (!UpdateStarted)
            {
                if (Metadata.ContainsKey("Parent") && Metadata.Get("Parent").Value.Capabilities.ContainsType("Pose"))
                {
                    StereoKit.Pose p = Metadata.Get("Parent").Value.Capabilities.ByType("Pose")[0].Value;
                    StereoKit.UI.WindowBegin(Title, ref p);
                    UpdateStarted = true;
                }
            }
        }

        public override void EndUpdate()
        {
            if (UpdateStarted)
            {
                StereoKit.UI.WindowEnd();
                UpdateStarted = false;
            }
        }
    }
}