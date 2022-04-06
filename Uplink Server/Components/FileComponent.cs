using System;

public class FileComponent : Component
{
    public byte[] Bytes;
    public string filePath;

    public FileComponent(string name, byte[] bytes, string path) : base(name)
    {
        Bytes = bytes;
        filePath = path;
    }
}