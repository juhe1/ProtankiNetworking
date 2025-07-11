using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Thunder fire (time).
/// </summary>
public class ThunderFireOut : AbstractPacket
{
    public const int ID_CONST = -136344740;
    public override int Id => ID_CONST;
    public override string Description => "Thunder fire (time)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance // time (was var_2174)
    };

    public override string[] Attributes => new[]
    {
        "time"
    };
}