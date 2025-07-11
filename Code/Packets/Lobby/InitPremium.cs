using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Initializes premium status and related notifications for the user.
/// </summary>
public class InitPremium : AbstractPacket
{
    public static int IdStatic { get; } = 1405859779;
    public override int Id => IdStatic;
    public override string Description => "Initialize premium status and notifications";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        BoolCodec.Instance, // needShowNotificationCompletionPremium
        BoolCodec.Instance, // needShowWelcomeAlert
        FloatCodec.Instance, // reminderCompletionPremiumTime
        BoolCodec.Instance, // wasShowAlertForFirstPurchasePremium
        BoolCodec.Instance, // wasShowReminderCompletionPremium
        IntCodec.Instance // lifeTimeInSeconds
    };

    public override string[] Attributes => new[]
    {
        "needShowNotificationCompletionPremium",
        "needShowWelcomeAlert",
        "reminderCompletionPremiumTime",
        "wasShowAlertForFirstPurchasePremium",
        "wasShowReminderCompletionPremium",
        "lifeTimeInSeconds"
    };
}