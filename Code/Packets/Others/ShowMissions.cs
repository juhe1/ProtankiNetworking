using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Show the list of missions currently available to the player
/// </summary>
public class ShowMissions : Packet
{
    [Encode(0)]
    public Mission?[]? Missions { get; set; }

    [Encode(1)]
    public MissionStreak? WeeklyStreakInfo { get; set; }

    public const int ID_CONST = 809822533;
    public override int Id => ID_CONST;
    public override string Description => "Show the list of missions currently available to the player";


}