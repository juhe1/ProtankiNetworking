using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Shaft;

public class ShaftLaserUpdateDirectionOutPacket : Packet
{

	[Encode(0)]
	public float ProjectionOnVerticalAxis { get; set; }

	public const int ID_CONST = 1224288585;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
