

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for sending Isida reset target out event.
/// </summary>
public class IsidaResetTargetOut : Packet
{
    [Encode(0)]
    public int Time { get; set; }

    public const int ID_CONST = -248693565;
    public override int Id => ID_CONST;
    public override string Description => "Send Isida reset target out event";


}