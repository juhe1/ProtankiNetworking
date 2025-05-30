using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Complex
{
    /// <summary>
    /// Codec for arrays of string values
    /// </summary>
    public class VectorStringCodec : BaseCodec<string[]>
    {
        private readonly StringCodec _stringCodec;

        /// <summary>
        /// Creates a new instance of VectorStringCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public VectorStringCodec(EByteArray buffer) : base(buffer)
        {
            _stringCodec = new StringCodec(buffer);
        }

        /// <summary>
        /// Decodes an array of string values from the buffer
        /// </summary>
        /// <returns>The decoded array of string values</returns>
        public override string[] Decode()
        {
            var length = Buffer.ReadShort();
            if (length == 0)
                return Array.Empty<string>();

            var result = new string[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = _stringCodec.Decode();
            }
            return result;
        }

        /// <summary>
        /// Encodes an array of string values to the buffer
        /// </summary>
        /// <param name="value">The array of string values to encode</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(string[] value)
        {
            if (value == null || value.Length == 0)
            {
                Buffer.WriteShort(0);
                return 2;
            }

            Buffer.WriteShort((short)value.Length);
            var totalBytes = 2;
            foreach (var str in value)
            {
                totalBytes += _stringCodec.Encode(str);
            }
            return totalBytes;
        }
    }
} 