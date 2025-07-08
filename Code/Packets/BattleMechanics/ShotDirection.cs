using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Shot direction
/// </summary>
public class RicochetFireIn : AbstractPacket
{
    public static int Id { get; } = -118119523;
    public override string Description => "Shot direction";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        ShortCodec.Instance,
        ShortCodec.Instance,
        ShortCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "shooter",
        "shotDirectionX",
        "shotDirectionY",
        "shotDirectionZ"
    };
}