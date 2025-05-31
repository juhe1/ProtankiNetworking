using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Battle user control packet
    /// </summary>
    public class BattleUserControl : AbstractPacket
    {
        public static new int Id { get; } = -301298508;
        public static new string Description { get; } = "Battle user control packet";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            ByteCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "tankiId",
            "control",
        };
    }
}
