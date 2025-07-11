using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Shaft laser update direction out (projectionOnVerticalAxis).
/// </summary>
public class ShaftLaserUpdateDirectionOut : AbstractPacket
{
    public const int IdStatic = 1224288585;
    public override int Id => IdStatic;
    public override string Description => "Shaft laser update direction out (projectionOnVerticalAxis)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        FloatCodec.Instance // projectionOnVerticalAxis
    };

    public override string[] Attributes => new[]
    {
        "projectionOnVerticalAxis"
    };
}