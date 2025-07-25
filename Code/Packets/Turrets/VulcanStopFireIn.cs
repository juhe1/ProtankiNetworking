

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Vulcan stop fire event.
/// </summary>
public class VulcanStopFireIn : Packet
{
    [Encode(0)]
    public string? ShooterId { get; set; }

    public const int ID_CONST = 133452238;
    public override int Id => ID_CONST;
    public override string Description => "Vulcan stop fire event";


}