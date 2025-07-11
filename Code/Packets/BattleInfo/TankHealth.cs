using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Updates the health of a tank
/// </summary>
public class TankHealth : AbstractPacket
{
    public const int ID_CONST = -611961116;
    public override int Id => ID_CONST;
    public override string Description => "Updates the health of a tank";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        FloatCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "username",
        "health"
    };
}