using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Player Rating stats
/// </summary>
public class LoadRatingStats : AbstractPacket
{
    public static int IdStatic { get; } = -1128606444;
    public override int Id => IdStatic;
    public override string Description => "Player Rating stats";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        FloatCodec.Instance,
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "rating",
        "place"
    };
}