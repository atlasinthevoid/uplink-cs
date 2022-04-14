﻿namespace Uplink.Component.Server
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Atlas' Uplink universe server");

            Entity client = Utility.CreateClient();

            TimeComponent t = new() {
                Name = "clock",
                Timer = true,
                Clock = true,
                SecondsToUpdate = 10
            };
            client.Add(t);

            TimeComponent tt = new()
            {
                Name = "status message",
                Timer = true,
                SecondsToUpdate = 10
            };
            client.Add(tt);

            Status status = new();
            client.Add(status);

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