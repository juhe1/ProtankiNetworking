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
        public static int Id { get; } = 546849203;
        public override string Description => "Shot Effect Applied";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            Vector3DCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "shooter",
            "hitPoint",
        };
    }
}
