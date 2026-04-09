using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Capturetheflag;

public class ReturnFlagToBaseInPacket : Packet
{

	[Encode(0)]
	public BattleTeam? FlagTeam { get; set; }

	[Encode(1)]
	public string? Tank { get; set; }

	public const int ID_CONST = -1026428589;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
