using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Sent when a mine is placed.
    /// </summary>
    public class MinePlace : AbstractPacket
    {
        public static new int Id { get; } = -624217047;
        public static new string Description { get; } = "Sent when a mine is placed.";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "mineId",
        };
    }
}
