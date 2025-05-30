using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// Starts a new round in the existing battle
    /// </summary>
    public class RoundStartPacket : AbstractPacket
    {
        public static new int Id { get; } = -344514517;
        public static new string Description { get; } = "Starts a new round in the existing battle";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "battleID" };
    }
} 