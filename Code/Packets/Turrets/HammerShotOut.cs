using ProtankiNetworking.EncodableData;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Player fires a hammer shot
/// </summary>
public class HammerShotOut : Packet
{
	[Encode(0)]
	public int ClientTime { get; set; }

	[Encode(1)]
	public Vector3D? Direction { get; set; }

	[Encode(2)]
	public TargetPosition?[]? Shots { get; set; }

	public const int ID_CONST = -541655881;
	public override int Id => ID_CONST;
	public override string Description => "Player fires a hammer shot";
}
