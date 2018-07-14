using System;

namespace Engine
{
    public unsafe class CMover
    {
        private readonly IntPtr ClassBase;

        private CMover(IntPtr classBase)
        {
            ClassBase = classBase;
        }

        public static CMover GetCMover(IntPtr classBase)
        {
            return new CMover(classBase);
        }

        public uint GetObjId()
        {
            return *(uint*)(ClassBase + 0x2F0);
        }
    }
}