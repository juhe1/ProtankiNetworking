using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for taking a daily quest prize (questId).
/// </summary>
public class TakeDailyQuestPrize : AbstractPacket
{
    public const int IdStatic = 1768449810;
    public override int Id => IdStatic;
    public override string Description => "Take daily quest prize (questId)";
    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance // questId
    };
    public override string[] Attributes => new[]
    {
        "questId"
    };
} 