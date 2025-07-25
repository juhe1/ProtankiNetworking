using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for opening the referrer panel (data, inviteLink, banner, inviteMessage).
/// </summary>
public class OpenReferrerPanel : Packet
{
    [Encode(0)]
    public ReferrerIncomeData?[]? Data { get; set; }

    [Encode(1)]
    public string? InviteLink { get; set; }

    [Encode(2)]
    public string? Banner { get; set; }

    [Encode(3)]
    public string? InviteMessage { get; set; }

    public const int ID_CONST = 1587315905;
    public override int Id => ID_CONST;
    public override string Description => "Open referrer panel (data, inviteLink, banner, inviteMessage)";
} 