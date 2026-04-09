using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Isida;

public class ResetIsidaTargetInPacket : Packet
{

	[Encode(0)]
	public string? Shooter { get; set; }

	public const int ID_CONST = -1271729363;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
