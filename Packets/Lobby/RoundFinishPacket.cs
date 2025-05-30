using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// The existing battle round has finished
    /// </summary>
    public class RoundFinishPacket : AbstractPacket
    {
        public static new int Id { get; } = 1534651002;
        public static new string Description { get; } = "The existing battle round has finished";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "battleID" };
    }
} 