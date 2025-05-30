using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// Swaps teams in a battle
    /// </summary>
    public class SwapTeamsPacket : AbstractPacket
    {
        public static new int Id { get; } = -994817471;
        public static new string Description { get; } = "Swaps teams in a battle";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "battleID" };
    }
} 