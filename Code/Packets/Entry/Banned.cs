using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Account banned
/// </summary>
public class Banned : AbstractPacket
{
    public const int ID_CONST = -600078553;
    public override int Id => ID_CONST;
    public override string Description => "Account banned";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "reason"
    };
}