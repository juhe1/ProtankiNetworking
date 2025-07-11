using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Flamethrower starting fire (shooter only).
/// </summary>
public class FlamethrowerStartFireIn : AbstractPacket
{
    public static int IdStatic { get; } = 1212381771;
    public override int Id => IdStatic;
    public override string Description => "Flamethrower start fire (shooter)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // shooter
    };

    public override string[] Attributes => new[]
    {
        "shooter"
    };
}