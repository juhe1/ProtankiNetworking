using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Information about fantom status of a player
    /// </summary>
    public class StartRespFantomPacket : AbstractPacket
    {
        public static new int Id { get; } = 875259457;
        public static new string Description { get; } = "Information about fantom status of a player";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(IntCodec), typeof(Vector3DCodec), typeof(Vector3DCodec), typeof(ShortCodec), typeof(ShortCodec) };
        public static new string[] Attributes { get; } = new[] { "username", "team", "position", "orientation", "health", "incarnationID" };
    }
} 