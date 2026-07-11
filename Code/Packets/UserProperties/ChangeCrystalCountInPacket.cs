using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.UserProperties;

public class ChangeCrystalCountInPacket : Packet
{

	[Encode(0)]
	public int CrystalCount { get; set; }

	public const int ID_CONST = -593513288;
	public override int Id => ID_CONST;
	public override string Description => "Changes the user crystal count shown in the panel.";
}
