using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Initializes premium status and related notifications for the user.
    /// </summary>
    public class InitPremium : AbstractPacket
    {
        public static int Id { get; } = 1405859779;
        public override string Description => "Initialize premium status and notifications";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            BoolCodec.Instance, // needShowNotificationCompletionPremium
            BoolCodec.Instance, // needShowWelcomeAlert
            FloatCodec.Instance, // reminderCompletionPremiumTime
            BoolCodec.Instance, // wasShowAlertForFirstPurchasePremium
            BoolCodec.Instance, // wasShowReminderCompletionPremium
            IntCodec.Instance, // lifeTimeInSeconds
        };
        public override string[] Attributes => new string[]
        {
            "needShowNotificationCompletionPremium",
            "needShowWelcomeAlert",
            "reminderCompletionPremiumTime",
            "wasShowAlertForFirstPurchasePremium",
            "wasShowReminderCompletionPremium",
            "lifeTimeInSeconds",
        };
    }
} 