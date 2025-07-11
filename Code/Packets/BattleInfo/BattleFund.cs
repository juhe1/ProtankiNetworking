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
        public const int ID_CONST = 1149211509;
        public override int Id => ID_CONST;
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