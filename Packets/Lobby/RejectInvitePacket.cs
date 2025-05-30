using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// Reject a player's battle invite
    /// </summary>
    public class RejectInvitePacket : AbstractPacket
    {
        public static new int Id { get; } = 1152865919;
        public static new string Description { get; } = "Reject a player's battle invite";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "username" };
    }
} 