using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Shot direction
    /// </summary>
    public class ShotDirection : AbstractPacket
    {
        public static new int Id { get; } = -118119523;
        public static new string Description { get; } = "Shot direction";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            ShortCodec.Instance,
            ShortCodec.Instance,
            ShortCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "shooter",
            "shotDirectionX",
            "shotDirectionY",
            "shotDirectionZ",
        };
    }
}
