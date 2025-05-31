using System.Text;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec.Complex
{
    /// <summary>
    /// Codec for string values
    /// </summary>
    public class StringCodec : BaseCodec
    {
        /// <summary>
        /// Gets the singleton instance of StringCodec
        /// </summary>
        public static StringCodec Instance { get; } = new StringCodec();

        private static readonly Encoding Encoding = Encoding.UTF8;

        /// <summary>
        /// Creates a new instance of StringCodec
        /// </summary>
        private StringCodec()
        {
        }

        /// <summary>
        /// Decodes a string value from the buffer
        /// </summary>
        /// <param name="buffer">The buffer to decode from</param>
        /// <returns>The decoded string value</returns>
        public override object Decode(EByteArray buffer)
        {
            var length = buffer.ReadShort();
            if (length == 0)
                return string.Empty;

            var bytes = buffer.ReadBytes(length);
            return Encoding.GetString(bytes);
        }

        /// <summary>
        /// Encodes a string value to the buffer
        /// </summary>
        /// <param name="value">The string value to encode</param>
        /// <param name="buffer">The buffer to encode to</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(object value, EByteArray buffer)
        {
            if (value is not string str)
            {
                throw new ArgumentException("Value must be a string", nameof(value));
            }

            if (string.IsNullOrEmpty(str))
            {
                buffer.WriteShort(0);
                return 2;
            }

            var bytes = Encoding.GetBytes(str);
            buffer.WriteShort((short)bytes.Length);
            buffer.Write(bytes);
            return 2 + bytes.Length;
        }
    }
} 