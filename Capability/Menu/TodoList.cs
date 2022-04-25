namespace Uplink.Capability.Menu
{
    public class TodoList : Capability
    {
        public TodoList()
        {
            StringType = "TodoList";
            Program.Systems.Register(this);
        }

        public override void Update()
        {

        }
    }
}