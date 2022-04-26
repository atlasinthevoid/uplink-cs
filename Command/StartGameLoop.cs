namespace Uplink.Command
{
    public class StartGameLoop : Command
    {
        public StartGameLoop()
        {
            StringType = "StartGameLoop";
        }

        internal override void Exec()
        {
            while (StereoKit.SK.Step(() =>
            {
                GameLoop g = new();
                g.Execute();
            })) ;
            StereoKit.SK.Shutdown();
        }

        public override void Undo()
        {

        }
    }
}
