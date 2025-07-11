using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for stopping Isida action.
/// </summary>
public class StopIsidaIn : AbstractPacket
{
    public static int IdStatic { get; } = 981035905;
    public override int Id => IdStatic;
    public override string Description => "Stop Isida action event";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // userId
    };

    public override string[] Attributes => new[]
    {
        "userId"
    };
}