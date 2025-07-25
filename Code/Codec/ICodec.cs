using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec;

/// <summary>
///     Interface for all codecs
/// </summary>
public interface ICodec
{
	/// <summary>
	/// If this is true, then the array that uses this as element code will
	/// get boolean at the begining that tells is the array null.
	/// </summary>
	bool IsArrayOptional { get; }

	/// <summary>
	/// The type that the codec will encode/decode.
	/// </summary>
	Type TargetType { get; }

	/// <summary>
	///     Decodes a value from the buffer
	/// </summary>
	/// <param name="buffer">The buffer to decode from</param>
	/// <returns>The decoded value</returns>
	object? Decode(EByteArray buffer);

	/// <summary>
	///     Encodes a value to the buffer
	/// </summary>
	/// <param name="value">The value to encode</param>
	/// <param name="buffer">The buffer to encode to</param>
	/// <returns>The number of bytes written</returns>
	int Encode(object? value, EByteArray buffer);
}
