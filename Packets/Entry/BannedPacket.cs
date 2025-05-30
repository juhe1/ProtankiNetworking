using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Entry
{
    /// <summary>
    /// Account banned
    /// </summary>
    public class BannedPacket : AbstractPacket
    {
        public static new int Id { get; } = -600078553;
        public static new string Description { get; } = "Account banned";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "reason" };
    }
} 