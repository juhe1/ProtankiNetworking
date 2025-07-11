using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for fire dummy command out (time, barrel).
/// </summary>
public class TwinsFireDummyOut : AbstractPacket
{
    public const int ID_CONST = -1805942142;
    public override int Id => ID_CONST;
    public override string Description => "Fire dummy command out (time, barrel).";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance, // time
        ByteCodec.Instance // barrel
    };

    public override string[] Attributes => new[]
    {
        "time",
        "barrel"
    };
}