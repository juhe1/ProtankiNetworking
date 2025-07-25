

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Freeze turret starting fire (shooter only).
/// </summary>
public class FreezeStartFireIn : Packet
{
    [Encode(0)]
    public string? Shooter { get; set; }

    public const int ID_CONST = -1171353580;
    public override int Id => ID_CONST;
    public override string Description => "Freeze start fire (shooter)";


}