using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Init;

public class ActivateProtectionInPacket : Packet
{

	[Encode(0)]
	public byte[]? Keys { get; set; }

	public const int ID_CONST = 2001736388;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
