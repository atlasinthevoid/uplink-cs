using WebSocketSharp;
using WebSocketSharp.Server;

namespace Uplink
{
    public class SocketComponent : Component
    {
        public SocketComponent()
        {
            CreateServer();
            CreateClient();
        }

        public override void Update()
        {

        }

        public void CreateServer()
        {
            Console.WriteLine("Created Server");
            var wssv = new WebSocketServer(System.Net.IPAddress.Any, 8080);

            wssv.AddWebSocketService<UplinkService>("/Uplink");
            wssv.Start();
        }

        public void StopServer()
        {
            //wssv.Stop();
        }

        public void CreateClient()
        {
            Console.WriteLine("Created Client");
            var ws = new WebSocket("ws://localhost:8080/Uplink");
            ws.OnMessage += new EventHandler<MessageEventArgs>(ClientOnMessage);

            // Sync

            ws.Connect();
            Entity e = new();
            ws.Send(Utility.SerializeObject<Entity>(new()));
        }

        public void StopClient()
        {
            //ws.Stop();
        }

        void ClientOnMessage(object? sender, MessageEventArgs e)
        {
            Console.WriteLine("Laputa says: " + e.Data);
        }
    }

    public class UplinkService : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            string msg = "";
            //Component es = e.Data as Component;

            Send(msg);
        }
    }
}