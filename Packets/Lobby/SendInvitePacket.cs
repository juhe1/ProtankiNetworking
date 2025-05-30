using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// Send a battle invite to a player
    /// </summary>
    public class SendInvitePacket : AbstractPacket
    {
        public static new int Id { get; } = -864265623;
        public static new string Description { get; } = "Send a battle invite to a player";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "username", "battleID" };
    }
} 