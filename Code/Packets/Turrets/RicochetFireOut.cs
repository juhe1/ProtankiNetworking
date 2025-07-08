using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for Ricochet fire out (time, shotId, shotDirectionX, shotDirectionY, shotDirectionZ).
    /// </summary>
    public class RicochetFireOut : AbstractPacket
    {
        public static int Id { get; } = -1907971330;
        public override string Description => "Ricochet fire out (time, shotId, shotDirectionX, shotDirectionY, shotDirectionZ)";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance, // time
            IntCodec.Instance, // shotId
            ShortCodec.Instance, // shotDirectionX
            ShortCodec.Instance, // shotDirectionY
            ShortCodec.Instance, // shotDirectionZ
        };
        public override string[] Attributes => new string[]
        {
            "time",
            "shotId",
            "shotDirectionX",
            "shotDirectionY",
            "shotDirectionZ",
        };
    }
} 