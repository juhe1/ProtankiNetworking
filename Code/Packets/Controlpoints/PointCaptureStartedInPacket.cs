using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Controlpoints;

public class PointCaptureStartedInPacket : Packet
{

	[Encode(0)]
	public BattleTeam? Team { get; set; }

	public const int ID_CONST = -1346883037;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
