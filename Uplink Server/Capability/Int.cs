﻿namespace Uplink.Capability
{
    public class Int : Capability
    {
        public int Number
        {
            get;
            init;
        }

        public Int()
        {
            Number = 0;
        }

        public override void Update()
        {

        }
    }
}