using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec.Primitive;

/// <summary>
///     Codec for long values
/// </summary>
public class LongCodec : BaseCodec
{
	public override Type TargetType { get; } = typeof(long);

	private LongCodec() { }

	public static LongCodec Instance { get; } = new();

	/// <summary>
	///     Decodes an long value from the buffer
	/// </summary>
	/// <param name="buffer">The buffer to decode from</param>
	/// <returns>The decoded long value</returns>
	public override object Decode(EByteArray buffer)
	{
		return buffer.ReadLong();
	}

	/// <summary>
	///     Encodes an long value to the buffer
	/// </summary>
	/// <param name="value">The long value to encode</param>
	/// <param name="buffer">The buffer to encode to</param>
	/// <returns>The number of bytes written</returns>
	public override int Encode(object? value, EByteArray buffer)
	{
		if (value is not long longValue)
			throw new ArgumentException("Value must be an long", nameof(value));

		buffer.WriteLong(longValue);
		return 8;
	}
}
