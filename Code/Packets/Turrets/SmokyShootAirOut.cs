using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Smokey Shoot at Air
/// </summary>
public class SmokyShootAirOut : AbstractPacket
{
    public const int IdStatic = 1478921140;
    public override int Id => IdStatic;
    public override string Description => "Smokey Shoot at Air";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "clientTime"
    };
}