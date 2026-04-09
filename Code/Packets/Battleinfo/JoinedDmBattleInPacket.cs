using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battleinfo;

public class JoinedDmBattleInPacket : Packet
{

	[Encode(0)]
	public string? BattleId { get; set; }

	[Encode(1)]
	public BattleInfoUser? UserInfo { get; set; }

	public const int ID_CONST = -911626491;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
