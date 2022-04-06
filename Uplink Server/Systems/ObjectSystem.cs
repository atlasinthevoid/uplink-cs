public class ObjectSystem : SystemComponent
{
    public ObjectSystem(string name, State state) : base(name, state)
    {

    }

    public void Update()
    {
        Console.WriteLine("update");
    }
}
