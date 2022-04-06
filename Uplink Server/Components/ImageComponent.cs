using System;

public class ImageComponent : Component
{
    public byte[] Bytes;

    public ImageComponent(string name, byte[] bytes) : base(name)
    {
        Bytes = bytes;
    }
}