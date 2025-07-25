using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec.Primitive;

/// <summary>
///     Codec for float values
/// </summary>
public class FloatCodec : BaseCodec
{
	public override Type TargetType { get; } = typeof(float);

	/// <summary>
	///     Creates a new instance of FloatCodec
	/// </summary>
	private FloatCodec() { }

	/// <summary>
	///     Gets the singleton instance of FloatCodec
	/// </summary>
	public static FloatCodec Instance { get; } = new();

	/// <summary>
	///     Decodes a float value from the buffer
	/// </summary>
	/// <param name="buffer">The buffer to decode from</param>
	/// <returns>The decoded float value</returns>
	public override object? Decode(EByteArray buffer)
	{
		return buffer.ReadFloat();
	}

	/// <summary>
	///     Encodes a float value to the buffer
	/// </summary>
	/// <param name="value">The float value to encode</param>
	/// <param name="buffer">The buffer to encode to</param>
	/// <returns>The number of bytes written</returns>
	public override int Encode(object? value, EByteArray buffer)
	{
		if (value is not float floatValue)
			throw new ArgumentException("Value must be a float", nameof(value));

		buffer.WriteFloat(floatValue);
		return 4;
	}
}

