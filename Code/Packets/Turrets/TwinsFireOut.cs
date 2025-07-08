using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for firing a turret: time, barrel, shotId, shotDirection.
    /// </summary>
    public class TwinsFireOut : AbstractPacket
    {
        public static int Id { get; } = -159686980;
        public override string Description => "Fire command (time, barrel, shotId, shotDirection).";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance, // time
            ByteCodec.Instance, // barrel
            IntCodec.Instance, // shotId
            Vector3DCodec.Instance, // shotDirection
        };
        public override string[] Attributes => new string[]
        {
            "time",
            "barrel",
            "shotId",
            "shotDirection",
        };
    }
} 