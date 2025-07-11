using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Tells the client which beginner rewards the player has yet to complete
/// </summary>
public class LoadNewbieRewards : AbstractPacket
{
    public const int ID_CONST = 602656160;
    public override int Id => ID_CONST;
    public override string Description => "Tells the client which beginner rewards the player has yet to complete";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        new VectorCodec(IntCodec.Instance, false)
    };

    public override string[] Attributes => new[]
    {
        "incompleteRewards"
    };
}