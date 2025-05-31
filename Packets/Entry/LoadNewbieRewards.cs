using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry
{
    /// <summary>
    /// Tells the client which beginner rewards the player has yet to complete
    /// </summary>
    public class LoadNewbieRewards : AbstractPacket
    {
        public static new int Id { get; } = 602656160;
        public static new string Description { get; } = "Tells the client which beginner rewards the player has yet to complete";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            new VectorCodec(IntCodec.Instance, false),
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "incompleteRewards",
        };
    }
}
