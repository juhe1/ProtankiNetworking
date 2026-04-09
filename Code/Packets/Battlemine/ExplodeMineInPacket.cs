using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlemine;

public class ExplodeMineInPacket : Packet
{

	[Encode(0)]
	public string? MineId { get; set; }

	[Encode(1)]
	public string? TargetId { get; set; }

	public const int ID_CONST = 1387974401;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
