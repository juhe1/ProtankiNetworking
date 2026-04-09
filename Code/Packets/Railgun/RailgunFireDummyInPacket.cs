using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Railgun;

public class RailgunFireDummyInPacket : Packet
{

	[Encode(0)]
	public string? Shooter { get; set; }

	public const int ID_CONST = 1459211021;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
