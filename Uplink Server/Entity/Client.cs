namespace Uplink.Entity
{
    public class Client : Entity
    {
        public Client()
        {
            _ = new Component.Audio() { Entity = Id };
            _ = new Component.Bool() { Entity = Id };
            _ = new Component.Broadcast() { Entity = Id };
            _ = new Component.File() { Entity = Id };
            _ = new Component.Float() { Entity = Id };
            _ = new Component.Id() { Entity = Id };
            _ = new Component.Image() { Entity = Id };
            _ = new Component.Int() { Entity = Id };
            _ = new Component.Loading() { Entity = Id };
            _ = new Component.Mesh() { Entity = Id };
            _ = new Component.Position() { Entity = Id };
            _ = new Component.Rotation() { Entity = Id };
            _ = new Component.Save() { Entity = Id };
            _ = new Component.Socket() { Entity = Id };
            _ = new Component.Status() { Entity = Id };
            _ = new Component.Terminal() { Entity = Id };
            _ = new Component.Text() { Entity = Id };
            _ = new Component.Time() { Entity = Id };
        }
    }
}
