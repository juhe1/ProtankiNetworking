using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Initiates a shaft scope shot
/// </summary>
public class ShaftScopeInitOut : AbstractPacket
{
    public static int IdStatic { get; } = -367760678;
    public override int Id => IdStatic;
    public override string Description => "Initiates a shaft scope shot";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "clientTime"
    };
}