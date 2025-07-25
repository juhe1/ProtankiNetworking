

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     A player has left the selected battle, from the preview screen
/// </summary>
public class LeftSelectedPreview : Packet
{
    [Encode(0)]
    public string? BattleID { get; set; }

    [Encode(1)]
    public string? Username { get; set; }

    public const int ID_CONST = 1924874982;
    public override int Id => ID_CONST;
    public override string Description => "A player has left the selected battle, from the preview screen";


}