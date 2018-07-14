using PInvoke;
using System;

namespace Engine
{
    public unsafe class WorldMng
    {
        private const int WORLDMNG_OFFSET = 0x848B70;
        private static IntPtr IgniteBase = Kernel32.GetModuleHandle(null).DangerousGetHandle();

        private static WorldMng instance;
        public static WorldMng Instance
        {
            get
            {
                return instance == null ? (instance = new WorldMng()) : instance;
            }
        }

        public World GetWorld()
        {
            return World.GetWorld(*(IntPtr*)(IgniteBase + WORLDMNG_OFFSET + 0xC));
        }
    }
}