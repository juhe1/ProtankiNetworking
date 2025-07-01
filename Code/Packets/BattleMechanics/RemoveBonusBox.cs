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
        public static int Id { get; } = -2026749922;
        public override string Description => "Supply box bonus id";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "bonusId",
        };
    }
}
