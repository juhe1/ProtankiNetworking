using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// Accepts a player's battle invite
    /// </summary>
    public class AcceptInvitePacket : AbstractPacket
    {
        public static new int Id { get; } = 814687528;
        public static new string Description { get; } = "Accepts a player's battle invite";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "username" };
    }
} 