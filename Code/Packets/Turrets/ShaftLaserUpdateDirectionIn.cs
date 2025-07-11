using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for updating Shaft laser direction (shooterId, projectionOnVerticalAxis).
/// </summary>
public class ShaftLaserUpdateDirectionIn : AbstractPacket
{
    public const int IdStatic = -534192254;
    public override int Id => IdStatic;
    public override string Description => "Shaft laser update direction (shooterId, projectionOnVerticalAxis)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance, // shooterId
        FloatCodec.Instance // projectionOnVerticalAxis
    };

    public override string[] Attributes => new[]
    {
        "shooterId",
        "projectionOnVerticalAxis"
    };
}