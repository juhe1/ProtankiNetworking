using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Status
{
    /// <summary>
    /// Updates Player's Online Status
    /// </summary>
    public class OnlineStatusPacket : AbstractPacket
    {
        public static new int Id { get; } = 2041598093;
        public static new string Description { get; } = "Updates Player's Online Status";
        public static new Type[] CodecTypes { get; } = new[] { typeof(BoolCodec), typeof(IntCodec), typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "online", "serverID", "username" };
        public static new bool ShouldLog { get; } = false;
    }
} 