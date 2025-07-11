using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Packet to indicate that the statistics object has been loaded (post event).
/// </summary>
public class StatisticsObjectLoadedPost : AbstractPacket
{
    public const int ID_CONST = 1953272681;
    public override int Id => ID_CONST;
    public override string Description => "Indicates that the statistics object has been loaded (post event)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}