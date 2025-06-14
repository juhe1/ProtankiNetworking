using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Shot effect packet
    /// </summary>
    public class ShotEffect : AbstractPacket
    {
        public static int Id { get; } = -1994318624;
        public override string Description => "Shot effect packet";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "username",
            "effectId",
        };
    }
}
