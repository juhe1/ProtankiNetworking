using System;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Complex
{
    /// <summary>
    /// Codec for arrays of byte values
    /// </summary>
    public class VectorByteCodec : BaseCodec<byte[]>
    {
        public VectorByteCodec(EByteArray buffer) : base(buffer) { }

        public override byte[] Decode()
        {
            var length = Buffer.ReadShort();
            if (length == 0)
                return Array.Empty<byte>();
            return Buffer.ReadBytes(length);
        }

        public override int Encode(byte[] value)
        {
            if (value == null || value.Length == 0)
            {
                Buffer.WriteShort(0);
                return 2;
            }
            Buffer.WriteShort((short)value.Length);
            Buffer.Write(value);
            return 2 + value.Length;
        }
    }
} 