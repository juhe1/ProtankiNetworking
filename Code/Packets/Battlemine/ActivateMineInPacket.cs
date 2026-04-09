using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlemine;

public class ActivateMineInPacket : Packet
{

	[Encode(0)]
	public string? MineId { get; set; }

	public const int ID_CONST = -624217047;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
