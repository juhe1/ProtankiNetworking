using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Battle time left in seconds
/// </summary>
public class BattleTimeLeft : AbstractPacket
{
    public const int ID_CONST = 732434644;
    public override int Id => ID_CONST;
    public override string Description => "Battle time left in seconds";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "timeLimitInSec"
    };
}