using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Supply box bonus id
    /// </summary>
    public class RemoveBonusBox : AbstractPacket
    {
        public static new int Id { get; } = -2026749922;
        public static new string Description { get; } = "Supply box bonus id";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "bonusId",
        };
    }
}
