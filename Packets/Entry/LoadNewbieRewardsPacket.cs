using ProboTankiLibCS.Codec.Primitive;
using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Entry
{
    /// <summary>
    /// Tells the client which beginner rewards the player has yet to complete
    /// </summary>
    public class LoadNewbieRewardsPacket : AbstractPacket
    {
        public static new int Id { get; } = 602656160;
        public static new string Description { get; } = "Tells the client which beginner rewards the player has yet to complete";
        public static new Type[] CodecTypes { get; } = new[] { typeof(VectorIntCodec) };
        public static new string[] Attributes { get; } = new[] { "incompleteRewards" };
    }
} 