

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Freeze stop fire event.
/// </summary>
public class FreezeStopFireIn : Packet
{
    [Encode(0)]
    public string? ShooterId { get; set; }

    public const int ID_CONST = 979099084;
    public override int Id => ID_CONST;
    public override string Description => "Freeze stop fire event";


}