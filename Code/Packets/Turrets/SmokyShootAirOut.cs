using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Smokey Shoot at Air
/// </summary>
public class SmokyShootAirOut : AbstractPacket
{
    public const int ID_CONST = 1478921140;
    public override int Id => ID_CONST;
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