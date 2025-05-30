using System.Text.Json;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Complex
{
    /// <summary>
    /// Codec for JSON objects
    /// </summary>
    public class JsonCodec : BaseCodec<object>
    {
        private static readonly JsonSerializerOptions Options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        /// <summary>
        /// Creates a new instance of JsonCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public JsonCodec(EByteArray buffer) : base(buffer)
        {
        }

        /// <summary>
        /// Decodes a JSON object from the buffer
        /// </summary>
        /// <returns>The decoded JSON object</returns>
        public override object Decode()
        {
            var jsonString = new StringCodec(Buffer).Decode();
            return JsonSerializer.Deserialize<object>(jsonString, Options);
        }

        /// <summary>
        /// Encodes a JSON object to the buffer
        /// </summary>
        /// <param name="value">The JSON object to encode</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(object value)
        {
            var jsonString = JsonSerializer.Serialize(value, Options);
            return new StringCodec(Buffer).Encode(jsonString);
        }
    }
} 