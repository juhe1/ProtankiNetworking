using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Init;

public class ResourcesLoadedOutPacket : Packet
{

	[Encode(0)]
	public int CallbackID { get; set; }

	public const int ID_CONST = -82304134;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
