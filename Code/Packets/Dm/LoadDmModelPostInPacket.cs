using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Dm;

public class LoadDmModelPostInPacket : Packet
{

	public const int ID_CONST = 930618015;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
