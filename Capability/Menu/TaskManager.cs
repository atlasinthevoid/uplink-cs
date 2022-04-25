namespace Uplink.Capability.Menu
{
    public class TaskManager : Capability
    {
        public TaskManager()
        {
            StringType = "TaskManager";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}