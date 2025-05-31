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
        public static new int Id { get; } = 1831462385;
        public static new string Description { get; } = "A bonus box has dropped";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            Vector3DCodec.Instance,
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "bonusId",
            "position",
            "fallTimeThreshold",
        };
    }
}
