

namespace ProtankiNetworking.Packets.Chat;

/// <summary>
///     Wipes all messages by a user in the lobby
/// </summary>
public class WipeLobbyMessages : Packet
{
    [Encode(0)]
    public string? Username { get; set; }

    public const int ID_CONST = 1993050216;
    public override int Id => ID_CONST;
    public override string Description => "Wipes all messages by a user in the lobby";


}