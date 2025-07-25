

namespace ProtankiNetworking.Packets.Status;

/// <summary>
///     Subscribe to status updates of a player.
/// </summary>
public class SubscribeStatus : Packet
{
    [Encode(0)]
    public string? Username { get; set; }

    public const int ID_CONST = 1774907609;
    public override int Id => ID_CONST;
    public override string Description => "Subscribe to status updates of a player.";


}