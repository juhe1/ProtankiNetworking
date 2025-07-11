using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Railgun fire dummy in (shooter).
/// </summary>
public class RailgunFireDummyIn : AbstractPacket
{
    public const int ID_CONST = 1459211021;
    public override int Id => ID_CONST;
    public override string Description => "Railgun fire dummy in (shooter)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // shooter
    };

    public override string[] Attributes => new[]
    {
        "shooter"
    };
}