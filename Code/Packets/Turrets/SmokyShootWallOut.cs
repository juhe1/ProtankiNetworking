using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Smokey Shoot out
/// </summary>
public class SmokyShootWallOut : AbstractPacket
{
    public const int ID_CONST = 1470597926;
    public override int Id => ID_CONST;
    public override string Description => "Smokey Shoot out";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance,
        Vector3DCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "clientTime",
        "hitPoint"
    };
}