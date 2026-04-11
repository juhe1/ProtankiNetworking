using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Tdm;

public class LoadTdmPostInPacket : Packet
{

	public const int ID_CONST = 183561709;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
