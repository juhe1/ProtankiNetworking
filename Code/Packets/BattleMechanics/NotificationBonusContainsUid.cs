using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Packet for notification bonus containing UID (text, uid).
    /// </summary>
    public class NotificationBonusContainsUid : AbstractPacket
    {
        public static int Id { get; } = 1382076950;
        public override string Description => "Notification bonus contains UID (text, uid)";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance, // text
            StringCodec.Instance, // uid
        };
        public override string[] Attributes => new string[]
        {
            "text",
            "uid",
        };
    }
} 