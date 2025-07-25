

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for navigating to a URL (url).
/// </summary>
public class NavigateToURL : Packet
{
    [Encode(0)]
    public string? Url { get; set; }

    public const int ID_CONST = -1455955413;
    public override int Id => ID_CONST;
    public override string Description => "Navigate to URL (url)";
} 