using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Client moved passively
/// </summary>
public class TankMovementInfo : AbstractPacket
{
    public const int ID_CONST = -1683279062;
    public override int Id => ID_CONST;
    public override string Description => "Client moved passively";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance,
        ShortCodec.Instance,
        MoveCodec.Instance,
        FloatCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "clientTime",
        "specificationID",
        "movement",
        "turretDirection"
    };
}