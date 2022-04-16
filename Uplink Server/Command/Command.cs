namespace Uplink.Command
{
    public abstract class Command
    {
        public Type.Result Data;

        public Command()
        {
            Data = new Type.Result();
        }
    }
}
