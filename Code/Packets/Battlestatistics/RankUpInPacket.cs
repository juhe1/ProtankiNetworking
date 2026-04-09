using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlestatistics;

public class RankUpInPacket : Packet
{

	[Encode(0)]
	public string? UserId { get; set; }

	[Encode(1)]
	public int Rank { get; set; }

	public const int ID_CONST = 1262947513;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
