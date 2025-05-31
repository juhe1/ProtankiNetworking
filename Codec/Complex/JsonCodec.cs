using System;
using System.Text;
using System.Text.Json;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec.Complex
{
    /// <summary>
    /// Codec for JSON values
    /// </summary>
    public class JsonCodec : BaseCodec
    {
        /// <summary>
        /// Gets the singleton instance of JsonCodec
        /// </summary>
        public static JsonCodec Instance { get; } = new JsonCodec();

        /// <summary>
        /// Creates a new instance of JsonCodec
        /// </summary>
        private JsonCodec()
        {
        }

        /// <summary>
        /// Decodes a JSON value from the buffer
        /// </summary>
        /// <param name="buffer">The buffer to decode from</param>
        /// <returns>The decoded JSON value</returns>
        public override object Decode(EByteArray buffer)
        {
            var length = buffer.ReadInt();
            if (length == 0)
                return null;

            var bytes = buffer.ReadBytes(length);
            var json = Encoding.UTF8.GetString(bytes);
            return JsonSerializer.Deserialize<object>(json);
        }

        /// <summary>
        /// Encodes a JSON value to the buffer
        /// </summary>
        /// <param name="value">The JSON value to encode</param>
        /// <param name="buffer">The buffer to encode to</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(object value, EByteArray buffer)
        {
            if (value == null)
            {
                buffer.WriteInt(0);
                return 4;
            }

            var json = JsonSerializer.Serialize(value);
            var bytes = Encoding.UTF8.GetBytes(json);
            buffer.WriteInt(bytes.Length);
            buffer.Write(bytes);
            return 4 + bytes.Length;
        }
    }
} 