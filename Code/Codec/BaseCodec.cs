using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec;

/// <summary>
///     Base class for all codecs, whether primitive or complex
/// </summary>
public abstract class BaseCodec : ICodec
{
	public abstract Type TargetType { get; }

	public virtual bool IsArrayOptional { get; } = false;

	protected BaseCodec() { }

	public abstract object? Decode(EByteArray buffer);

	public abstract int Encode(object? value, EByteArray buffer);
}
