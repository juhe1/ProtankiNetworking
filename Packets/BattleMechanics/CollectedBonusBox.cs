using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// A bonus box was picked up
    /// </summary>
    public class CollectedBonusBox : AbstractPacket
    {
        public static int Id { get; } = -1291499147;
        public override string Description => "A bonus box was picked up";
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
