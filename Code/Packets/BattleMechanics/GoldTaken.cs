using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for gold box taken event (uid).
/// </summary>
public class GoldTaken : AbstractPacket
{
    public static int Id { get; } = 463494974;
    public override string Description => "Gold taken (uid)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // uid
    };

    public override string[] Attributes => new[]
    {
        "uid"
    };
}