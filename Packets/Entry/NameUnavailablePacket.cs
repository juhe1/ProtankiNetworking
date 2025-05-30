using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Entry
{
    /// <summary>
    /// Said name is unavailable for registration with a list of alternative suggested usernames
    /// </summary>
    public class NameUnavailablePacket : AbstractPacket
    {
        public static new int Id { get; } = 442888643;
        public static new string Description { get; } = "Said name is unavailable for registration with a list of alternative suggested usernames";
        public static new Type[] CodecTypes { get; } = new[] { typeof(VectorStringCodec) };
        public static new string[] Attributes { get; } = new[] { "usernames" };
    }
} 