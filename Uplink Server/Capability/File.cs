﻿using System.Collections.Immutable;

namespace Uplink.Capability
{
    public class File : Capability
    {
        public ImmutableArray<byte> Bytes
        {
            get;
            init;
        }

        public string FilePath
        {
            get;
            init;
        }

        public File()
        {
            Bytes = new();
            FilePath = "";
            Program.FileSystem.Register(this);
        }

        public override void Update()
        {
            
        }
    }
}