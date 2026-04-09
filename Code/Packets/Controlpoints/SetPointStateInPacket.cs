using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Controlpoints;

public class SetPointStateInPacket : Packet
{

	[Encode(0)]
	public int PointId { get; set; }

	[Encode(1)]
	public int CurrentState { get; set; }

	public const int ID_CONST = -1073178885;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
