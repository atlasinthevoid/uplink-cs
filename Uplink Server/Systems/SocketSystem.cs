public class SocketSystem : SystemComponent
{
    public SocketSystem(string name, State state) : base(name, state)
    {

    }

    public void Update()
    {
        Console.WriteLine("update");
    }
}