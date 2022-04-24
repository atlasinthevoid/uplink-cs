namespace Uplink.Command
{
    public class GameLoop : Command
    {
        public GameLoop()
        {
            StringType = "GameLoop";
        }

        internal override void Exec()
        {
            Program.AudioSystem.Update();
            Program.BoolSystem.Update();
            Program.BroadcastSystem.Update();
            Program.CapabilitySystem.Update();
            Program.FileSystem.Update();
            Program.FloatSystem.Update();
            Program.IdSystem.Update();
            Program.ImageSystem.Update();
            Program.IntSystem.Update();
            Program.LoadingSystem.Update();
            Program.MeshSystem.Update();
            Program.PositionSystem.Update();
            Program.SaveSystem.Update();
            Program.SocketSystem.Update();
            Program.StatusSystem.Update();
            Program.TerminalSystem.Update();
            Program.TextSystem.Update();
            Program.TimeSystem.Update();
            Program.PoseSystem.Update();
            Program.MatrixSystem.Update();
        }

        public override void Undo()
        {

        }
    }
}
