

namespace ProtankiNetworking.Packets.Status;

/// <summary>
///     Updates a player's premium status
/// </summary>
public class PremiumStatus : Packet
{
    [Encode(0)]
    public int TimeLeft { get; set; }

    [Encode(1)]
    public string? Username { get; set; }

    public const int ID_CONST = -2069508071;
    public override int Id => ID_CONST;
    public override string Description => "Updates a player's premium status";


}