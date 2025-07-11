using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for gold box taken event (uid).
/// </summary>
public class GoldTaken : AbstractPacket
{
    public const int ID_CONST = 463494974;
    public override int Id => ID_CONST;
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