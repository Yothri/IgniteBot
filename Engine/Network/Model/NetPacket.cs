namespace Engine.Network.Model
{
    public class NetPacket : NetPacketStream
    {
        public NetPacket()
        {
            Write(0xFFFFFFFF);
        }
    }
}