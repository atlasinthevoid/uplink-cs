using System;
using System.Numerics;

public class IdComponent : Component
{
    public Guid? Id;

    public IdComponent(string name, Guid id) : base(name)
    {
        Id = id;
    }
}