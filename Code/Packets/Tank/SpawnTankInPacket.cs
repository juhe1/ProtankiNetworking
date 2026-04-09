using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Tank;

public class SpawnTankInPacket : Packet
{

	[Encode(0)]
	public string? TankId { get; set; }

	[Encode(1)]
	public BattleTeam? Team { get; set; }

	[Encode(2)]
	public Vector3D? Position { get; set; }

	[Encode(3)]
	public Vector3D? Orientation { get; set; }

	[Encode(4)]
	public short Health { get; set; }

	[Encode(5)]
	public short IncarnationId { get; set; }

	public const int ID_CONST = 875259457;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
