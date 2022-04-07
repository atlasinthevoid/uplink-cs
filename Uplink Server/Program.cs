using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.Json;
using System.Xml.Serialization;

namespace Uplink
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Atlas' Uplink universe server");

            State state = new();
            Entity client = Utility.CreateClient(state);
            state.Entities.Add(client);

            bool running = true;
            while (running)
            {
                foreach (dynamic component in client.Components)
                {
                    if (component is SystemComponent)
                    {
                        component.Update();
                    }
                }
            }

        }
    }
}