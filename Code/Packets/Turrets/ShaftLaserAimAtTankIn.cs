using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Shaft laser aiming at a tank, with local spot position.
/// </summary>
public class ShaftLaserAimAtTankIn : Packet
{
    [Encode(0)]
    public string? ShooterId { get; set; }

    [Encode(1)]
    public string? TargetTank { get; set; }

    [Encode(2)]
    public Vector3D? LocalSpotPosition { get; set; }

    public const int ID_CONST = 11992250;
    public override int Id => ID_CONST;
    public override string Description => "Shaft laser aim at tank (shooterId, targetTank, localSpotPosition)";


}