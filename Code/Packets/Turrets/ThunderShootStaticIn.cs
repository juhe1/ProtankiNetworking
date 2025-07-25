using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for sending Thunder shoot static event.
/// </summary>
public class ThunderShootStaticIn : Packet
{
    [Encode(0)]
    public string? Shooter { get; set; }

    [Encode(1)]
    public Vector3D? HitPoint { get; set; }

    public const int ID_CONST = 1690491826;
    public override int Id => ID_CONST;
    public override string Description => "Send Thunder shoot static event";


}