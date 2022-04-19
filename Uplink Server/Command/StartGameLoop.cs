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
            bool running = true;
            while (running)
            {
                GameLoop g = new();
                g.Execute();
            }
        }

        public override void Undo()
        {

        }
    }
}
