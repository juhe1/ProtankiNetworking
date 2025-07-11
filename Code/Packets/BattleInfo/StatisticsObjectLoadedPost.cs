using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Packet to indicate that the statistics object has been loaded (post event).
/// </summary>
public class StatisticsObjectLoadedPost : AbstractPacket
{
    public const int IdStatic = 1953272681;
    public override int Id => IdStatic;
    public override string Description => "Indicates that the statistics object has been loaded (post event)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}