using System;
using System.Numerics;

public class RotationComponent : Component
{
    public Vector3? Number;

    public RotationComponent(string name, Vector3 number) : base(name)
    {
        Number = number;
    }
}