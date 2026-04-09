using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Panel;

public class SetDoubleCrystalStateInPacket : Packet
{

	[Encode(0)]
	public bool Enabled { get; set; }

	public const int ID_CONST = 150222118;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
