using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Entry
{
    /// <summary>
    /// Check if a name is up for registration
    /// </summary>
    public class CheckNameAvailabilityPacket : AbstractPacket
    {
        public static new int Id { get; } = 1083705823;
        public static new string Description { get; } = "Check if a name is up for registration";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "username" };
    }
} 