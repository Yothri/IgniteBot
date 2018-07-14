namespace Engine.Network
{
    public static class Cryptography
    {
        public static void XorPayload(ref byte[] buffer)
        {
            if (buffer.Length != 0)
            {
                var i = 0;
                do
                {
                    var v7 = i ^ (-1 - i);
                    buffer[i] ^= (byte)(v7 ^ 0x13);
                    ++i;
                } while (i < buffer.Length);
            }
        }
    }
}