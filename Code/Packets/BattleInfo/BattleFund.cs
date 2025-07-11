using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Battle fund
    /// </summary>
    public class BattleFund : AbstractPacket
    {
        public const int IdStatic = 1149211509;
        public override int Id => IdStatic;
    public override string Description => "Battle fund";

        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
        };

        public override string[] Attributes => new string[]
        {
            "fund",
        };
    }
}