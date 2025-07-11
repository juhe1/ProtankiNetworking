using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for hiding Shaft laser (shooterId only).
/// </summary>
public class ShaftLaserHideIn : AbstractPacket
{
    public const int IdStatic = -380595194;
    public override int Id => IdStatic;
    public override string Description => "Shaft laser hide (shooterId)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // shooterId
    };

    public override string[] Attributes => new[]
    {
        "shooterId"
    };
}