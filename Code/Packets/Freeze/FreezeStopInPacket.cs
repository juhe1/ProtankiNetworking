using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Freeze;

public class FreezeStopInPacket : Packet
{

	[Encode(0)]
	public string? Shooter { get; set; }

	public const int ID_CONST = 979099084;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
