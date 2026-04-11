using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Init;

public class HideLoaderInPacket : Packet
{

	public const int ID_CONST = -1282173466;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
