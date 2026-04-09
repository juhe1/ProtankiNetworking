using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Controlpoints;

public class PointCaptureStoppedInPacket : Packet
{

	[Encode(0)]
	public BattleTeam? Team { get; set; }

	public const int ID_CONST = -1701488017;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
