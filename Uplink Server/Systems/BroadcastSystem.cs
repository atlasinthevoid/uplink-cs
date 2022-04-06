public class BroadcastSystem : SystemComponent
{
    public BroadcastSystem(string name, State state) : base(name, state)
    {

    }

    public void Update()
    {
        Console.WriteLine("update");
    }
}