using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.UserProperties;

public class UpdateRatingAndPlaceInPacket : Packet
{
	
	[Encode(0)]
	public float Rating { get; set; }

	[Encode(1)]
	public int Place { get; set; }

	public const int ID_CONST = -1128606444;
	public override int Id => ID_CONST;
	public override string Description => "Updates the user rating and place shown in the panel.";
}
