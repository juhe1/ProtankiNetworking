using System;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Complex
{
    /// <summary>
    /// Represents a pair of integers.
    /// </summary>
    public struct IntPair
    {
        public int First { get; set; }
        public int Second { get; set; }
        public IntPair(int first, int second)
        {
            First = first;
            Second = second;
        }
    }

    /// <summary>
    /// Codec for arrays of IntPair values
    /// </summary>
    public class VectorIntPairCodec : BaseCodec<IntPair[]>
    {
        public VectorIntPairCodec(EByteArray buffer) : base(buffer) { }

        public override IntPair[] Decode()
        {
            var length = Buffer.ReadShort();
            if (length == 0)
                return Array.Empty<IntPair>();
            var result = new IntPair[length];
            for (int i = 0; i < length; i++)
            {
                int first = Buffer.ReadInt();
                int second = Buffer.ReadInt();
                result[i] = new IntPair(first, second);
            }
            return result;
        }

        public override int Encode(IntPair[] value)
        {
            if (value == null || value.Length == 0)
            {
                Buffer.WriteShort(0);
                return 2;
            }
            Buffer.WriteShort((short)value.Length);
            var totalBytes = 2;
            foreach (var pair in value)
            {
                Buffer.WriteInt(pair.First);
                Buffer.WriteInt(pair.Second);
                totalBytes += 8;
            }
            return totalBytes;
        }
    }
} 