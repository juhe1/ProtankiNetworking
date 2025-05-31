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
        public static new int Id { get; } = -1291499147;
        public static new string Description { get; } = "A bonus box was picked up";
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
