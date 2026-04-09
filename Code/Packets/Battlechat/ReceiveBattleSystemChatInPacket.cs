using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlechat;

public class ReceiveBattleSystemChatInPacket : Packet
{

	[Encode(0)]
	public string? Message { get; set; }

	public const int ID_CONST = 606668848;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
