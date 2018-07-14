using System;

namespace Engine
{
    public unsafe class World
    {
        private readonly IntPtr ClassBase;

        private World(IntPtr classBase)
        {
            ClassBase = classBase;
        }

        public static World GetWorld(IntPtr classBase)
        {
            return new World(classBase);
        }

        public CMover GetFocusedObj()
        {
            var pFocusedObj = *(IntPtr*)(ClassBase + 0x20);
            if (pFocusedObj == IntPtr.Zero)
                return null;

            return CMover.GetCMover(pFocusedObj);
        }
    }
}