using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Others
{
    /// <summary>
    /// Check if the user has notification on
    /// </summary>
    public class SettingsNotificationPacket : AbstractPacket
    {
        public static new int Id { get; } = 1447082276;
        public static new string Description { get; } = "Check if the user has notification on";
        public static new Type[] CodecTypes { get; } = new[] { typeof(BoolCodec) };
        public static new string[] Attributes { get; } = new[] { "notificationEnabled" };
    }
} 