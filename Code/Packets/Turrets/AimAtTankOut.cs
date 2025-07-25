using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for aiming at a tank (targetTank, localSpotPosition).
/// </summary>
public class AimAtTankOut : Packet
{
    [Encode(0)]
    public string? TargetTank { get; set; }

    [Encode(1)]
    public Vector3D? LocalSpotPosition { get; set; }

    public const int ID_CONST = -1517837003;
    public override int Id => ID_CONST;
    public override string Description => "Aim at tank out (targetTank, localSpotPosition)";


}