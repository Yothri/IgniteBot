//#define IGNITE

using Engine.Network;
using Engine.Network.Model;
using PInvoke;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Engine
{
    public static unsafe class Networking
    {
        private static IntPtr IgniteBase = Kernel32.GetModuleHandle(null).DangerousGetHandle();

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate void tSend(void* ecx, byte* lpData, uint dwDataSize, uint dpidTo);
#if IGNITE
        private static tSend NativeSend = Marshal.GetDelegateForFunctionPointer<tSend>(IgniteBase + 0x313CC0);
#else
        private static tSend NativeSend = Marshal.GetDelegateForFunctionPointer<tSend>(IgniteBase + 0x413570);
#endif


        public static void SendPacket(NetPacket packet)
        {
#if IGNITE
            var pDPClient = *(IntPtr*)(*(IntPtr*)(IgniteBase + 0x57E2D8 + 4) + 4);
#else
            var pDPClient = *(IntPtr*)(*(IntPtr*)(IgniteBase + 0x83C920 + 4) + 4);
#endif
            var payloadData = packet.ToArray();
            var payloadHandle = GCHandle.Alloc(payloadData, GCHandleType.Pinned);

#if IGNITE
            Cryptography.XorPayload(ref payloadData);
#endif

            NativeSend((void*)pDPClient, (byte*)payloadHandle.AddrOfPinnedObject(), (uint)payloadData.Length, 1u);

            payloadHandle.Free();
        }

        public static void SendChat(string message)
        {
            var messageData = Encoding.ASCII.GetBytes(message);

            using (var packet = new NetPacket())
            {
#if IGNITE
                packet.Write(0x58);
#else
                packet.Write(0x00ff0000);
#endif
                packet.Write(messageData.Length);
                packet.Write(messageData);

                SendPacket(packet);
            }
        }

        public static void SendSetTarget(uint targetId, byte bClear)
        {
            using (var packet = new NetPacket())
            {
#if IGNITE
                packet.Write(0x79);
#else
                packet.Write(0x00ff0023);
#endif
                packet.Write(targetId);
                packet.Write(bClear);

                SendPacket(packet);
            }
        }

        public static void SendPlayerDestObj(uint objId, float range)
        {
            using (var packet = new NetPacket())
            {
#if IGNITE
                throw new NotImplementedException();
#else
                packet.Write(0xffffff07);
#endif
                packet.Write(objId);
                packet.Write(range);

                SendPacket(packet);
            }
        }

        public static void SendMeleeAttack(uint atkMsg, uint objId, int nparam, int nparam2, float fval)
        {
            using (var packet = new NetPacket())
            {
#if IGNITE
                throw new NotImplementedException();
#else
                packet.Write(0x00ff0010);
#endif
                packet.Write(atkMsg);
                packet.Write(objId);
                packet.Write(nparam);
                packet.Write(nparam2);
                packet.Write(fval);

                SendPacket(packet);
            }
        }
    }
}