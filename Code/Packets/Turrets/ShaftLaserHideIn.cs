using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for hiding Shaft laser (shooterId only).
/// </summary>
public class ShaftLaserHideIn : AbstractPacket
{
    public const int ID_CONST = -380595194;
    public override int Id => ID_CONST;
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