using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Entry
{
    /// <summary>
    /// Loads the player's friend lists
    /// </summary>
    public class LoadFriendsListPacket : AbstractPacket
    {
        public static new int Id { get; } = 1422563374;
        public static new string Description { get; } = "Loads the player's friend lists";
        public static new Type[] CodecTypes { get; } = new[] { typeof(VectorStringCodec), typeof(VectorStringCodec), typeof(VectorStringCodec), typeof(VectorStringCodec), typeof(VectorStringCodec) };
        public static new string[] Attributes { get; } = new[] { "accepted", "newAccepted", "incoming", "newIncoming", "outgoing" };
    }
} 