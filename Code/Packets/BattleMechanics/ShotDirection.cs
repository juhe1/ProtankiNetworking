namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Shot direction
/// </summary>
public class RicochetFireIn : Packet
{
	[Encode(0)]
	public string? Shooter { get; set; }

	[Encode(1)]
	public short ShotDirectionX { get; set; }

	[Encode(2)]
	public short ShotDirectionY { get; set; }

	[Encode(3)]
	public short ShotDirectionZ { get; set; }

	public const int ID_CONST = -118119523;
	public override int Id => ID_CONST;
	public override string Description => "Shot direction";
}
