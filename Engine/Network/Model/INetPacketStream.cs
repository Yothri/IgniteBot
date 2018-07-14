using System;

namespace Engine.Network.Model
{
    public interface INetPacketStream : IDisposable
    {
        void Write<T>(T value);
    }
}