using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Capturetheflag;

public class FlagDeliveredInPacket : Packet
{

	[Encode(0)]
	public BattleTeam? WinnerTeam { get; set; }

	[Encode(1)]
	public string? DelivererTankId { get; set; }

	public const int ID_CONST = -1870108387;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
