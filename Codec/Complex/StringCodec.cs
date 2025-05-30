using System.Text;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Complex
{
    /// <summary>
    /// Codec for string values
    /// </summary>
    public class StringCodec : BaseCodec<string>
    {
        private static readonly Encoding Encoding = Encoding.UTF8;

        /// <summary>
        /// Creates a new instance of StringCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public StringCodec(EByteArray buffer) : base(buffer)
        {
        }

        /// <summary>
        /// Decodes a string value from the buffer
        /// </summary>
        /// <returns>The decoded string value</returns>
        public override string Decode()
        {
            var length = Buffer.ReadShort();
            if (length == 0)
                return string.Empty;

            var bytes = Buffer.ReadBytes(length);
            return Encoding.GetString(bytes);
        }

        /// <summary>
        /// Encodes a string value to the buffer
        /// </summary>
        /// <param name="value">The string value to encode</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                Buffer.WriteShort(0);
                return 2;
            }

            var bytes = Encoding.GetBytes(value);
            Buffer.WriteShort((short)bytes.Length);
            Buffer.Write(bytes);
            return 2 + bytes.Length;
        }
    }
} 