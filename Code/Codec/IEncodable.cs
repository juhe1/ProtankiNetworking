namespace ProtankiNetworking.Codec;

/// <summary>
/// Every object that implements this will guarantee that the object
/// can be encoded and decoded.
/// </summary>
interface IEncodable
{
	/// <summary>
	/// If this is true then when the value is encoded, it will get boolean at the start that tells is the value null or not.
	/// </summary>
	bool IsOptional { get; }

	/// <summary>
	/// If this is true then when the array that uses this as an type is encoded, it will get boolean at the start that tells is the array null or not.
	/// In protanki client code this variable is called optionalVector.
	/// </summary>
	bool IsArrayOptional { get; }
}
