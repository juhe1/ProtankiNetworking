using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec.Complex;

/// <summary>
///     Codec for Vector3D values
/// </summary>
public class Vector3DCodec : BaseCodec
{
	public override Type TargetType { get; } = typeof(Vector3D);
	public override bool IsArrayOptional { get; } = true;

	/// <summary>
	///     Creates a new instance of Vector3DCodec
	/// </summary>
	private Vector3DCodec() { }

	/// <summary>
	///     Gets the singleton instance of Vector3DCodec
	/// </summary>
	public static Vector3DCodec Instance { get; } = new();

	/// <summary>
	///     Decodes a Vector3D value from the buffer
	/// </summary>
	/// <param name="buffer">The buffer to decode from</param>
	/// <returns>The decoded Vector3D value</returns>
	public override object? Decode(EByteArray buffer)
	{
		bool isEmpty = buffer.ReadBoolean();
		if (isEmpty)
			return null;
		var x = buffer.ReadFloat();
		var y = buffer.ReadFloat();
		var z = buffer.ReadFloat();
		return new Vector3D(x, y, z);
	}

	/// <summary>
	///     Encodes a Vector3D value to the buffer
	/// </summary>
	/// <param name="value">The Vector3D value to encode</param>
	/// <param name="buffer">The buffer to encode to</param>
	/// <returns>The number of bytes written</returns>
	public override int Encode(object? value, EByteArray buffer)
	{
		if (value is null)
		{
			buffer.WriteBoolean(true);
			return 1;
		}

		if (value is not Vector3D vector)
			throw new ArgumentException("Value must be a Vector3D", nameof(value));

		buffer.WriteFloat(vector.X);
		buffer.WriteFloat(vector.Y);
		buffer.WriteFloat(vector.Z);
		return 12;
	}
}
