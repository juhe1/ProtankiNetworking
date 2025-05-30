using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Effect Aftermath
    /// </summary>
    public class EffectAftermathPacket : AbstractPacket
    {
        public static new int Id { get; } = -1639713644;
        public static new string Description { get; } = "Effect Aftermath";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(IntCodec), typeof(IntCodec), typeof(BoolCodec), typeof(ByteCodec) };
        public static new string[] Attributes { get; } = new[] { "username", "effectId", "duration", "activeAfterDeath", "effectLevel" };
    }
} 