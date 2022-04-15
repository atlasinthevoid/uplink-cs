namespace Uplink.Command
{
    public abstract class Command
    {
        public Result Data;

        public Command()
        {
            Data = new Result();
        }
    }
}
