using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleInfo
{
    /// <summary>
    /// A tank has been killed
    /// </summary>
    public class KillConfirmPacket : AbstractPacket
    {
        public static new int Id { get; } = -42520728;
        public static new string Description { get; } = "A tank has been killed";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(StringCodec), typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "target", "killer", "respDelay" };
    }
} 