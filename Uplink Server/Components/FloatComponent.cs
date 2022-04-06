using System;

public class FloatComponent : Component
{
    public float? Number;

    public FloatComponent(string name, int number) : base(name)
    {
        Number = number;
    }
}