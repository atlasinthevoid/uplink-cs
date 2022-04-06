public class SystemComponent : Component
{
    public State LocalState;

    public SystemComponent(string name, State state) : base(name)
    {
        LocalState = state;
    }
}
