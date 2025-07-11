using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for setting a tank's temperature (tankId, temperature).
/// </summary>
public class SetTankTemperature : AbstractPacket
{
    public const int ID_CONST = 581377054;
    public override int Id => ID_CONST;
    public override string Description => "Set tank temperature (tankId, temperature)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance, // tankId
        FloatCodec.Instance // temperature
    };

    public override string[] Attributes => new[]
    {
        "tankId",
        "temperature"
    };
}