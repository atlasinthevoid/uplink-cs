namespace Uplink.Command
{
    public class StartGameLoop : Command
    {
        public StartGameLoop()
        {
            StringType = "StartGameLoop";
        }
        StereoKit.Pose windowPoseButton = new(0, 1, -0.5f, StereoKit.Quat.FromAngles(0, 180, 0));

        internal override void Exec()
        {
            while (StereoKit.SK.Step(() =>
            {
                GameLoop g = new();
                g.Execute();
                ShowWindowButton();

            })) ;
            StereoKit.SK.Shutdown();
        }

        void ShowWindowButton()
        {
            StereoKit.UI.WindowBegin("Window Button", ref windowPoseButton);

            if (StereoKit.UI.Button("Press me!"))
                StereoKit.Log.Info("Button was pressed.");

            StereoKit.UI.WindowEnd();
        }

        public override void Undo()
        {

        }
    }
}
