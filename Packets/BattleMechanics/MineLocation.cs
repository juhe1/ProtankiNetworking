using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Sent when a mine is placed or removed.
    /// </summary>
    public class MineLocation : AbstractPacket
    {
        public static new int Id { get; } = 272183855;
        public static new string Description { get; } = "Sent when a mine is placed or removed.";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            FloatCodec.Instance,
            FloatCodec.Instance,
            FloatCodec.Instance,
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "mineId",
            "x",
            "y",
            "z",
            "userId",
        };
    }
}
