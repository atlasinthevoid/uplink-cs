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
            Program.Systems.Update();
            Program.Systems.EndUpdate();
        }

        public override void Undo()
        {

        }
    }
}
