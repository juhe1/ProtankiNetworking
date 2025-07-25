using System.Text.Json;
using System.Text.Json.Nodes;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec.Complex;

/// <summary>
///     Codec for JSON values
/// </summary>
public class JsonCodec : BaseCodec
{
	public override Type TargetType { get; } = typeof(JsonNode);

	/// <summary>
	///     Creates a new instance of JsonCodec
	/// </summary>


	/// <summary>
	///     Creates a new instance of JsonCodec
	/// </summary>
	private JsonCodec() { }

	/// <summary>
	///     Gets the singleton instance of JsonCodec
	/// </summary>
	public static JsonCodec Instance { get; } = new();

	/// <summary>
	///     Decodes a JSON value from the buffer
	/// </summary>
	/// <param name="buffer">The buffer to decode from</param>
	/// <returns>The decoded JSON value</returns>
	public override object? Decode(EByteArray buffer)
	{
		string? jsonString = (string?)StringCodec.Instance.Decode(buffer);
		if (jsonString is null)
			throw new Exception("jsonString cannot be null");
		JsonNode? jsonNode = JsonNode.Parse(jsonString);
		if (jsonNode is null)
			throw new Exception("jsonNode cannot be null");
		return (JsonNode)jsonNode;
	}

	/// <summary>
	///     Encodes a JSON value to the buffer
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
