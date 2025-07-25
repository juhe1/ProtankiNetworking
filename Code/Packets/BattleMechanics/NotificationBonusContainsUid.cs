

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for notification bonus containing UID (text, uid).
/// </summary>
public class NotificationBonusContainsUid : Packet
{
    [Encode(0)]
    public string? Text { get; set; }

    [Encode(1)]
    public string? Uid { get; set; }

    public const int ID_CONST = 1382076950;
    public override int Id => ID_CONST;
    public override string Description => "Notification bonus contains UID (text, uid)";


}