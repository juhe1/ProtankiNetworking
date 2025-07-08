using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for sending Thunder shoot static event.
/// </summary>
public class ThunderShootStaticIn : AbstractPacket
{
    public static int Id { get; } = 1690491826;
    public override string Description => "Send Thunder shoot static event";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance, // shooter
        Vector3DCodec.Instance // hitPoint
    };

    public override string[] Attributes => new[]
    {
        "shooter",
        "hitPoint"
    };
}