namespace Uplink.Capability.Core
{
    public class Client : Capability
    {
        public Client()
        {
            StringType = "Client";
            Program.Systems.Register(this);
        }

        public override void Update()
        {
            if(Metadata.ContainsKey("Parent"))
            {
                Type.Entity p = Metadata.Get("Parent").Value;
                if (!p.Capabilities.ContainsType("Loading"))
                {
                    p.Add(new Menu.Loading());
                }

                if (!p.Capabilities.ContainsType("Socket"))
                {
                    p.Add(new Socket());
                }

                if (!p.Capabilities.ContainsType("Status"))
                {
                    p.Add(new Menu.Status());
                }

                if (!p.Capabilities.ContainsType("Terminal"))
                {
                    p.Add(new Menu.Terminal());
                }
            
                if (!p.Capabilities.ContainsType("Time"))
                {
                    Time t = new()
                    {
                        Timer = true,
                        Clock = true,
                        SecondsToUpdate = 10
                    };
                    t.Metadata.Add(new Type.Name() { Value = "Clock" });
                    p.Add(t);

                    Time tt = new()
                    {
                        Timer = true,
                        SecondsToUpdate = 10
                    };
                    tt.Metadata.Add(new Type.Name() { Value = "Status message" });
                    p.Add(tt);
                }
            }
        }
    }
}
