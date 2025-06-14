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
        public static int Id { get; } = 602656160;
        public override string Description => "Tells the client which beginner rewards the player has yet to complete";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            new VectorCodec(IntCodec.Instance, false),
        };
        public override string[] Attributes => new string[]
        {
            "incompleteRewards",
        };
    }
}
