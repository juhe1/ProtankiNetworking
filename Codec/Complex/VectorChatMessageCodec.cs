using System;
using System.Collections.Generic;
using ProboTankiLibCS.Codec.Custom;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Complex
{
    /// <summary>
    /// Codec for arrays of chat message values
    /// </summary>
    public class VectorChatMessageCodec : BaseCodec<Dictionary<string, object>[]>
    {
        public VectorChatMessageCodec(EByteArray buffer) : base(buffer) { }

        public override Dictionary<string, object>[] Decode()
        {
            var length = Buffer.ReadShort();
            if (length == 0)
                return Array.Empty<Dictionary<string, object>>();
            var result = new Dictionary<string, object>[length];
            var codec = new ChatMessageCodec(Buffer);
            for (int i = 0; i < length; i++)
                result[i] = codec.Decode();
            return result;
        }

        public override int Encode(Dictionary<string, object>[] value)
        {
            if (value == null || value.Length == 0)
            {
                Buffer.WriteShort(0);
                return 2;
            }
            Buffer.WriteShort((short)value.Length);
            var totalBytes = 2;
            var codec = new ChatMessageCodec(Buffer);
            foreach (var val in value)
                totalBytes += codec.Encode(val);
            return totalBytes;
        }
    }
} 