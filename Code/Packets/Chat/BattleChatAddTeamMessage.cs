using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Chat;

/// <summary>
///     Packet for adding a team message to battle chat (userId, message, team).
/// </summary>
public class BattleChatAddTeamMessage : Packet
{
    [Encode(0)]
    public string? UserId { get; set; }

    [Encode(1)]
    public string? Message { get; set; }

    [Encode(2)]
    public BattleTeam? Team { get; set; }

    public const int ID_CONST = -449356094;
    public override int Id => ID_CONST;
    public override string Description => "Battle chat add team message (userId, message, team)";


}