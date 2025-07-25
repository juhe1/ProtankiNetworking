

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for sending Isida stop out event.
/// </summary>
public class IsidaStopOut : Packet
{
    [Encode(0)]
    public int Time { get; set; }

    public const int ID_CONST = -1051248475;
    public override int Id => ID_CONST;
    public override string Description => "Send Isida stop out event";


}