using System;

public class IntComponent : Component
{
    public int? Number;

    public IntComponent(string name, int number) : base(name)
    {
        Number = number;
    }
}