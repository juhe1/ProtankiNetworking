

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Check if the user has notification on
/// </summary>
public class SettingsNotification : Packet
{
    [Encode(0)]
    public bool NotificationEnabled { get; set; }

    public const int ID_CONST = 1447082276;
    public override int Id => ID_CONST;
    public override string Description => "Check if the user has notification on";


}