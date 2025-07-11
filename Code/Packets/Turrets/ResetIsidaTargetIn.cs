using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Reset Isida target event.
/// </summary>
public class ResetIsidaTargetIn : AbstractPacket
{
    public const int IdStatic = -1271729363;
    public override int Id => IdStatic;
    public override string Description => "Reset Isida target event";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // userId
    };

    public override string[] Attributes => new[]
    {
        "userId"
    };
}