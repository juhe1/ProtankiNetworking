using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Flamethrower stopping fire (shooter only).
/// </summary>
public class FlamethrowerStopFireIn : AbstractPacket
{
    public const int ID_CONST = 1333088437;
    public override int Id => ID_CONST;
    public override string Description => "Flamethrower stop fire (shooter)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // shooter
    };

    public override string[] Attributes => new[]
    {
        "shooter"
    };
}