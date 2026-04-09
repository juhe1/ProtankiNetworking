using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Capturetheflag;

public class FlagTakenInPacket : Packet
{

	[Encode(0)]
	public string? TankId { get; set; }

	[Encode(1)]
	public BattleTeam? FlagTeam { get; set; }

	public const int ID_CONST = -1282406496;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
