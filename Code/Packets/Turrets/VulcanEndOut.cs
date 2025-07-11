using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Vulcan stops shooting
/// </summary>
public class VulcanEndOut : AbstractPacket
{
    public const int ID_CONST = 1794372798;
    public override int Id => ID_CONST;
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