using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Flamethrower;

public class FlamethrowerStartFireInPacket : Packet
{

	[Encode(0)]
	public string? Shooter { get; set; }

	public const int ID_CONST = 1212381771;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
