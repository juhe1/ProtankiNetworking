using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Player Start Position
/// </summary>
public class PlayerStartPosition : Packet
{
	[Encode(0)]
	public Vector3D? Position { get; set; }

	[Encode(1)]
	public Vector3D? Orientation { get; set; }

	public const int ID_CONST = -157204477;
	public override int Id => ID_CONST;
	public override string Description => "Player Start Position";
}
