using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for setting a tank's temperature (tankId, temperature).
/// </summary>
public class SetTankTemperature : AbstractPacket
{
    public static int IdStatic { get; } = 581377054;
    public override int Id => IdStatic;
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