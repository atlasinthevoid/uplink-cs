﻿namespace Uplink.Capability
{
    public class Audio : Capability
    {
        public List<byte> Bytes;

        public Audio()
        {
            StringType = "Audio";
            Bytes = new();
            Program.AudioSystem.Register(this);
        }

        public override void Update()
        {

        }
    }
}