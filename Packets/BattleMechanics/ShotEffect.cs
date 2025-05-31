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
        public static new int Id { get; } = -1994318624;
        public static new string Description { get; } = "Shot effect packet";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "username",
            "effectId",
        };
    }
}
