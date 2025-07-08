using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for setting Isida target.
/// </summary>
public class SetIsidaTargetIn : AbstractPacket
{
    public static int IdStatic { get; } = 2001632000;
    public override int Id => IdStatic;
    public override string Description => "Set Isida target event";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance, // userId
        IsisStateCodec.Instance, // isisState
        TargetHitCodec.Instance // target
    };

    public override string[] Attributes => new[]
    {
        "userId",
        "isisState",
        "target"
    };
}