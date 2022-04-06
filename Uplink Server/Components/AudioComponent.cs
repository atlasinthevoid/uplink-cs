using System;

public class AudioComponent : Component
{
    public byte[] Bytes;

    public AudioComponent(string name, byte[] bytes) : base(name)
    {
        Bytes = bytes;
    }
}