using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Sends current turret rotation data to the server
/// </summary>
public class TurretRotation : Packet
{
	[Encode(0)]
	public int ClientTime { get; set; }

	[Encode(1)]
	public TurretRotate? Rotation { get; set; }

	[Encode(2)]
	public short IncarnationID { get; set; }

	public const int ID_CONST = -114968993;
	public override int Id => ID_CONST;
	public override string Description => "Sends current turret rotation data to the server";
}
