using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battle;

public class RemoveBonusBoxInPacket : Packet
{

	[Encode(0)]
	public string? BonusId { get; set; }

	public const int ID_CONST = -2026749922;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
