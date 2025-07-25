

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for taking a daily quest prize (questId).
/// </summary>
public class TakeDailyQuestPrize : Packet
{
    [Encode(0)]
    public int QuestId { get; set; }

    public const int ID_CONST = 1768449810;
    public override int Id => ID_CONST;
    public override string Description => "Take daily quest prize (questId)";
} 