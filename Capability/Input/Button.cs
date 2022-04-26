namespace Uplink.Capability.Input
{
    public class Button : Capability
    {
        public string Title;

        public Button()
        {
            StringType = "Button";
            Title = "";
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            if (Metadata.ContainsKey("Parent") && Metadata.Get("Parent").Value.Capabilities.ContainsType("Window"))
            {
                Menu.Window w = Metadata.Get("Parent").Value.Capabilities.ByType("Window")[0];
                if (!w.UpdateStarted)
                {
                    w.Update();
                }

                if (StereoKit.UI.Button(Title))
                {
                    StereoKit.Log.Info("Button was pressed.");
                }
            }
        }
    }
}