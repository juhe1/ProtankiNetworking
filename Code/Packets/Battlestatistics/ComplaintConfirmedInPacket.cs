using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlestatistics;

public class ComplaintConfirmedInPacket : Packet
{

	public const int ID_CONST = 1249639251;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
