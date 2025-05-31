using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Effect Aftermath
    /// </summary>
    public class EffectAftermath : AbstractPacket
    {
        public static new int Id { get; } = -1639713644;
        public static new string Description { get; } = "Effect Aftermath";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            IntCodec.Instance,
            IntCodec.Instance,
            BoolCodec.Instance,
            ByteCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "username",
            "effectId",
            "duration",
            "activeAfterDeath",
            "effectLevel",
        };
    }
}
