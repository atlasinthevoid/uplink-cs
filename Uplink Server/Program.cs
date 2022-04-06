using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.Json;

Console.WriteLine("Atlas' Uplink universe server");

State state = new();

Entity client = new() { 
    new ObjectSystem("object system", state),
    new SocketSystem("socket system", state),
    new BroadcastSystem("broadcast system", state),
    new NetworkEventSystem("network event system", state),
    new SaveSystem("save system", state),
    new LoadingSystem("loading system", state),
    new StatusSystem("status system", state),
    new TerminalSystem("terminal system", state),
};
client.Add(new Component("client"));
client.Add(new Component(client.Id.ToString()));

state.Entities.Add(client);

bool running = true;
while (running)
{
    foreach (dynamic component in client.Components.Values)
    {
        if (component.GetType().IsSubclassOf(new SystemComponent("test", state).GetType()))
        {
            component.Update();
        }
    }
}
