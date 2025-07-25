using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Player shot a shot.
/// </summary>
public class PlayerShot : Packet
{
    [Encode(0)]
    public string? Shooter { get; set; }

    [Encode(1)]
    public byte Barrel { get; set; }

    [Encode(2)]
    public int ShotId { get; set; }

    [Encode(3)]
    public Vector3D? ShotDirection { get; set; }

    public const int ID_CONST = -44282936;
    public override int Id => ID_CONST;
    public override string Description => "Player shot a shot.";


}