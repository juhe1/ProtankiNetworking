using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Information about a self destructed tank
/// </summary>
public class SelfDestructed : AbstractPacket
{
    public const int ID_CONST = 162656882;
    public override int Id => ID_CONST;
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