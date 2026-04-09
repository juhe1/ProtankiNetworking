using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class UserPropertiesCC : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public int Crystals { get; set; }

	[Encode(1)]
	public int DurationCrystalAbonement { get; set; }

	[Encode(2)]
	public bool HasDoubleCrystal { get; set; }

	[Encode(3)]
	public int Place { get; set; }

	[Encode(4)]
	public int Rank { get; set; }

	[Encode(5)]
	public float UserRating { get; set; }

	[Encode(6)]
	public int Score { get; set; }

	[Encode(7)]
	public int ServerNumber { get; set; }

	[Encode(8)]
	public string? UserProfileUrl { get; set; }

}
