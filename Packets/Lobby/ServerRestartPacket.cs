using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// Indicates time (in seconds) until server restart
    /// </summary>
    public class ServerRestartPacket : AbstractPacket
    {
        public static new int Id { get; } = -1712113407;
        public static new string Description { get; } = "Indicates time (in seconds) until server restart";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "time" };
    }
} 