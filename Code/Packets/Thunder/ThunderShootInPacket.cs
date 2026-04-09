using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Thunder;

public class ThunderShootInPacket : Packet
{

	[Encode(0)]
	public string? Shooter { get; set; }

	public const int ID_CONST = 958509220;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
