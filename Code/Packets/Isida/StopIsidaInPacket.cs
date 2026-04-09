using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Isida;

public class StopIsidaInPacket : Packet
{

	[Encode(0)]
	public string? Shooter { get; set; }

	public const int ID_CONST = 981035905;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
