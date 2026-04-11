using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battleinfo;

public class JoinBattleOutPacket : Packet
{

	[Encode(0)]
	public BattleTeam? Team { get; set; }

	public const int ID_CONST = -1284211503;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
