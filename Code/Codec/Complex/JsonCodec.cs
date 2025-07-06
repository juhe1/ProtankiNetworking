using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
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
        public override object? Decode(EByteArray buffer)
        {
            string jsonString = (string)StringCodec.Instance.Decode(buffer);
            return JsonNode.Parse(jsonString);;
        }

        /// <summary>
        /// Encodes a JSON value to the buffer
        /// </summary>
        /// <param name="value">The JSON value to encode</param>
        /// <param name="buffer">The buffer to encode to</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(object? value, EByteArray buffer)
        {
            string jsonString = JsonSerializer.Serialize(value);
            return StringCodec.Instance.Encode(jsonString, buffer);
        }
    }
} 