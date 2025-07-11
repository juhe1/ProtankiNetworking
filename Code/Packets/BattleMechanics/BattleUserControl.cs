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
        public const int IdStatic = -301298508;
        public override int Id => IdStatic;
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