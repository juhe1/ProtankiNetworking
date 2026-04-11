using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Ping;

public class PingInPacket : Packet
{

	public const int ID_CONST = -555602629;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
