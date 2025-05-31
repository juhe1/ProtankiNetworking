using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Others
{
    /// <summary>
    /// Check if the user has notification on
    /// </summary>
    public class SettingsNotification : AbstractPacket
    {
        public static new int Id { get; } = 1447082276;
        public static new string Description { get; } = "Check if the user has notification on";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            BoolCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "notificationEnabled",
        };
    }
}
