using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battleinfo;

public class FightFailedServerHaltingInPacket : Packet
{

	[Encode(0)]
	public string? BattleId { get; set; }

	public const int ID_CONST = -831998018;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
