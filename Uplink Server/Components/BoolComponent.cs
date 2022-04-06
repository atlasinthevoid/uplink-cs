using System;
using System.Numerics;

public class BoolComponent : Component
{
    public bool? Flag;

    public BoolComponent(string name, bool flag) : base(name)
    {
        Flag = flag;
    }
}