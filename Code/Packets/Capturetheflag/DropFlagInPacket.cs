using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Capturetheflag;

public class DropFlagInPacket : Packet
{

	[Encode(0)]
	public Vector3D? Position { get; set; }

	[Encode(1)]
	public BattleTeam? FlagTeam { get; set; }

	public const int ID_CONST = 1925237062;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
