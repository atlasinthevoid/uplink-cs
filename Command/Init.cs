namespace Uplink.Command
{
    public class Init : Command
    {
        public Init()
        {
            StringType = "Init";
        }

        internal override void Exec()
        {
            Log l = new();
            l.Message = "Atlas' Uplink server";
            l.Execute();

            Entity.Client client = new();

            Capability.Time t = new()
            {
                Timer = true,
                Clock = true,
                SecondsToUpdate = 10
            };
            t.Metadata.Add(new Type.Name() { Value = "Clock" });
            client.Add(t);

            Capability.Time tt = new()
            {
                Timer = true,
                SecondsToUpdate = 10
            };
            tt.Metadata.Add(new Type.Name() { Value = "Status message" });
            client.Add(tt);
        }

        public override void Undo()
        {

        }
    }
}
