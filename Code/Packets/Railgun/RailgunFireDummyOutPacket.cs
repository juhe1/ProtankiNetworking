using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Railgun;

public class RailgunFireDummyOutPacket : Packet
{

	[Encode(0)]
	public int Time { get; set; }

	public const int ID_CONST = -18176641;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
