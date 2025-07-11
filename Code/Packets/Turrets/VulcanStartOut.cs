using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Vulcan starts shooting
/// </summary>
public class VulcanStartOut : AbstractPacket
{
    public static int IdStatic { get; } = -520655432;
    public override int Id => IdStatic;
    public override string Description => "Vulcan starts shooting";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "clientTime"
    };
}