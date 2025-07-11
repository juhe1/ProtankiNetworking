using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Status;

/// <summary>
///     Loads the rank of a player
/// </summary>
public class RankStatus : AbstractPacket
{
    public const int ID_CONST = -962759489;
    public override int Id => ID_CONST;
    public override string Description => "Loads the rank of a player";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance,
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "rank",
        "username"
    };
}