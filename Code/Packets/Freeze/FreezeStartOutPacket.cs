using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Freeze;

public class FreezeStartOutPacket : Packet
{

	[Encode(0)]
	public int ClientTime { get; set; }

	public const int ID_CONST = -75406982;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
