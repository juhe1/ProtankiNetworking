using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// A bonus box has dropped
    /// </summary>
    public class BonusBoxDropped : AbstractPacket
    {
        public static int Id { get; } = 1831462385;
        public override string Description => "A bonus box has dropped";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            Vector3DCodec.Instance,
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "bonusId",
            "position",
            "fallTimeThreshold",
        };
    }
}
