using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Vulcan starts shooting
/// </summary>
public class VulcanStartOut : AbstractPacket
{
    public const int ID_CONST = -520655432;
    public override int Id => ID_CONST;
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