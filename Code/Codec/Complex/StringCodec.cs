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
        public override object? Decode(EByteArray buffer)
        {
            bool isEmpty = buffer.ReadBoolean();
            if (isEmpty)
                return null;

            var length = buffer.ReadInt();
            if (length == 0)
                return string.Empty;

            return buffer.ReadString(length);
        }

        /// <summary>
        /// Encodes a string value to the buffer
        /// </summary>
        /// <param name="value">The string value to encode</param>
        /// <param name="buffer">The buffer to encode to</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(object? value, EByteArray buffer)
        {
            if (value is null)
            {
                buffer.WriteBoolean(true);
                return 1;
            }
            string str = (string)value;
            buffer.WriteBoolean(false);
            buffer.WriteInt(str.Length);
            buffer.WriteString(str);
            return 1 + 4 + str.Length;
        }
    }
} 