using Uplink.Program;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Uplink.Capability
{
    public class Socket : Capability
    {
        public Socket()
        {
            StringType = "Socket";
            CreateServer();
            CreateClient();
            Program.SocketSystem.Register(this);
        }

        public override void Update()
        {

        }

        public void CreateServer()
        {
            Command.Log l = new();
            l.Message = "Created Server";
            l.Execute();

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
            Command.Log l = new();
            l.Message = "Created Client";
            l.Execute();

            var ws = new WebSocket("ws://localhost:8080/Uplink");
            ws.OnMessage += new EventHandler<MessageEventArgs>(ClientOnMessage);

            // Sync

            ws.Connect();
            //ws.Send(AudioSystem.Capabilities.Get()[0].SerializeObject());
        }

        public void StopClient()
        {
            //ws.Stop();
        }

        void ClientOnMessage(object? sender, MessageEventArgs e)
        {
            Command.Log l = new();
            l.Message = "Laputa says: " + e.Data;
            l.Execute();
        }
    }

    public class UplinkService : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            //string msg = "";
            //Component es = e.Data as Component;

            Send(e.Data);
        }
    }
}