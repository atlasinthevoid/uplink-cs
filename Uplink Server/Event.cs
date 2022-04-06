using System;

public class Event
{
    public Guid Id;
    public DateTime Time;
    public Guid Author;
    public string Type;
    public Entity Object;
    public TaskCompletionSource<dynamic> Task;
    bool processed;
    bool synced;

    public Event(Guid author, string type, Entity newObject)
    {
        Id = Guid.NewGuid();
        Time = DateTime.UtcNow;
        Author = author;
        Type = type;
        Object = newObject;
        Task = new();
        processed = false;
        synced = false;
    }
}