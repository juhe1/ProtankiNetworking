using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Shot Effect Applied
/// </summary>
public class ShotEffectApplied : Packet
{
    [Encode(0)]
    public string? Shooter { get; set; }

    [Encode(1)]
    public Vector3D? HitPoint { get; set; }

    public const int ID_CONST = 546849203;
    public override int Id => ID_CONST;
    public override string Description => "Shot Effect Applied";


}