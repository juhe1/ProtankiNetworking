using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlechat;

public class SendBattleChatOutPacket : Packet
{

	[Encode(0)]
	public string? Message { get; set; }

	[Encode(1)]
	public bool TeamOnly { get; set; }

	public const int ID_CONST = 945463181;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
