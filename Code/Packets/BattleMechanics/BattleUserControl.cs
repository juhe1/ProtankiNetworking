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
        public static int Id { get; } = -301298508;
        public override string Description => "Battle user control packet";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            ByteCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "tankiId",
            "control",
        };
    }
}
