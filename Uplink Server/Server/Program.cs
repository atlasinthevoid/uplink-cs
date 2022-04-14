namespace Uplink.Component.Server
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Atlas' Uplink universe server");

            State state = new();
            Entity.Client client = new();

            Time t = new() {
                Entity = client.Id,
                Name = "clock",
                Timer = true,
                Clock = true,
                SecondsToUpdate = 10
            };

            Time tt = new()
            {
                Entity = client.Id
                Name = "status message",
                Timer = true,
                SecondsToUpdate = 10
            };

            Status status = new()
            {
                Entity = client.Id
            };

            bool running = true;
            while (running)
            {
                foreach (dynamic component in client.Components)
                {
                    //Console.WriteLine(component.GetType().FullName);
                    component.Update();
                }
            }
        }
    }
}