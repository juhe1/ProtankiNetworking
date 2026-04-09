using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Flamethrower;

public class FlamethrowerStopFireInPacket : Packet
{

	[Encode(0)]
	public string? Shooter { get; set; }

	public const int ID_CONST = 1333088437;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
