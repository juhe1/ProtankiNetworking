using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for loading chat configuration.
/// </summary>
public class LoadChat : Packet
{
    [Encode(0)]
    public bool Admin { get; set; }

    [Encode(1)]
    public bool AntifloodEnabled { get; set; }

    [Encode(2)]
    public int BufferSize { get; set; }

    [Encode(3)]
    public bool ChatEnabled { get; set; }

    [Encode(4)]
    public ChatModeratorLevel? ChatModeratorLevel { get; set; }

    [Encode(5)]
    public string?[]? LinksWhiteList { get; set; }

    [Encode(6)]
    public int MinChar { get; set; }

    [Encode(7)]
    public int MinWord { get; set; }

    [Encode(8)]
    public string? SelfName { get; set; }

    [Encode(9)]
    public bool ShowLinks { get; set; }

    [Encode(10)]
    public bool TypingSpeedAntifloodEnabled { get; set; }

    public const int ID_CONST = 178154988;
    public override int Id => ID_CONST;
    public override string Description => "Load chat configuration";


}