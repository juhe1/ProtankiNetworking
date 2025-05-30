using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Shot direction
    /// </summary>
    public class ShotDirectionPacket : AbstractPacket
    {
        public static new int Id { get; } = -118119523;
        public static new string Description { get; } = "Shot direction";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(ShortCodec), typeof(ShortCodec), typeof(ShortCodec) };
        public static new string[] Attributes { get; } = new[] { "shooter", "shotDirectionX", "shotDirectionY", "shotDirectionZ" };
    }
} 