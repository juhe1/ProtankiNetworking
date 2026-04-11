using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Ping;

public class PongOutPacket : Packet
{

	public const int ID_CONST = 1484572481;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
