using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Account banned
/// </summary>
public class Banned : AbstractPacket
{
    public static int Id { get; } = -600078553;
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