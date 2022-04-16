﻿using System.Collections.Immutable;

namespace Uplink.Capability
{
    public class Image : Capability
    {
        public ImmutableArray<byte> Bytes
        {
            get;
            init;
        }

        public Image()
        {
            Bytes = new();
        }

        public override void Update()
        {
            
        }
    }
}