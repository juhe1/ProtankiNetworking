using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Vulcan stops shooting
/// </summary>
public class VulcanEndOut : AbstractPacket
{
    public static int IdStatic { get; } = 1794372798;
    public override int Id => IdStatic;
    public override string Description => "Vulcan stops shooting";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "clientTime"
    };
}