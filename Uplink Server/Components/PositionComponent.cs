using System;
using System.Numerics;

public class PositionComponent : Component
{
    public Vector3? Number;

    public PositionComponent(string name, Vector3 number) : base(name)
    {
        Number = number;
    }
}