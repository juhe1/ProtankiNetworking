using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Isida;

public class IsidaResetTargetOutPacket : Packet
{

	[Encode(0)]
	public int ClientTime { get; set; }

	public const int ID_CONST = -248693565;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
