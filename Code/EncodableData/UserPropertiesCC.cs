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
	public int CurrentRankScore { get; set; }

	[Encode(2)]
	public int DurationCrystalAbonement { get; set; }

	[Encode(3)]
	public bool HasDoubleCrystal { get; set; }

	[Encode(4)]
	public int NextRankScore { get; set; }

	[Encode(5)]
	public int Place { get; set; }

	[Encode(6)]
	public byte Rank { get; set; }

	[Encode(7)]
	public float Rating { get; set; }

	[Encode(8)]
	public int Score { get; set; }

	[Encode(9)]
	public int ServerNumber { get; set; }

	[Encode(10)]
	public string? UserId { get; set; }

	[Encode(11)]
	public string? ProfileUrl { get; set; }
}
