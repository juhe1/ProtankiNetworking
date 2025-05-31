using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Shot Effect Applied
    /// </summary>
    public class ShotEffectApplied : AbstractPacket
    {
        public static new int Id { get; } = 546849203;
        public static new string Description { get; } = "Shot Effect Applied";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            Vector3DCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "shooter",
            "hitPoint",
        };
    }
}
