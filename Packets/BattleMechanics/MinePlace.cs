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
        public static int Id { get; } = -624217047;
        public override string Description => "Sent when a mine is placed.";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "mineId",
        };
    }
}
