namespace Uplink.Entity
{
    public class Client : Entity
    {
        public Client()
        {
            client.Add(new StateComponent());
            client.Add(new AudioComponent());
            client.Add(new BoolComponent());
            client.Add(new BroadcastComponent());
            client.Add(new FileComponent());
            client.Add(new FloatComponent());
            client.Add(new IdComponent());
            client.Add(new ImageComponent());
            client.Add(new IntComponent());
            client.Add(new LoadingComponent());
            client.Add(new MeshComponent());
            client.Add(new PositionComponent());
            client.Add(new RotationComponent());
            client.Add(new SaveComponent());
            client.Add(new SocketComponent());
            client.Add(new StatusComponent());
            client.Add(new TerminalComponent());
            client.Add(new TextComponent());
            client.Add(new TimeComponent());
            client.Add(new IdComponent() { Name = "client" });
            client.Add(new StateComponent());
        }
    }
}
