using System;

public class MeshComponent : Component
{
    public byte[] Bytes;

    public MeshComponent(string name, byte[] bytes) : base(name)
    {
        Bytes = bytes;
    }
}