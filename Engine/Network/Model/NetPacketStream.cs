using System;
using System.IO;

namespace Engine.Network.Model
{
    public abstract class NetPacketStream : MemoryStream, INetPacketStream
    {
        private readonly BinaryWriter Writer;

        public NetPacketStream()
        {
            Writer = new BinaryWriter(this);
        }

        public void Write<T>(T value)
        {
            if (typeof(T) == typeof(char))
                Writer.Write((char)(object)value);
            else if (typeof(T) == typeof(byte))
                Writer.Write((byte)(object)value);
            else if (typeof(T) == typeof(bool))
                Writer.Write((bool)(object)value);
            else if (typeof(T) == typeof(ushort))
                Writer.Write((ushort)(object)value);
            else if (typeof(T) == typeof(short))
                Writer.Write((short)(object)value);
            else if (typeof(T) == typeof(uint))
                Writer.Write((uint)(object)value);
            else if (typeof(T) == typeof(int))
                Writer.Write((int)(object)value);
            else if (typeof(T) == typeof(ulong))
                Writer.Write((ulong)(object)value);
            else if (typeof(T) == typeof(long))
                Writer.Write((long)(object)value);
            else if (typeof(T) == typeof(float))
                Writer.Write((float)(object)value);
            else if (typeof(T) == typeof(double))
                Writer.Write((double)(object)value);
            else if (typeof(T) == typeof(byte[]))
                Writer.Write((byte[])(object)value);
            else
                throw new NotImplementedException(nameof(T));
        }
    }
}