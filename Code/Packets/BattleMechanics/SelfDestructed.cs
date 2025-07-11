using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Information about a self destructed tank
/// </summary>
public class SelfDestructed : AbstractPacket
{
    public static int IdStatic { get; } = 162656882;
    public override int Id => IdStatic;
    public override string Description => "Information about a self destructed tank";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "username",
        "respDelay"
    };
}