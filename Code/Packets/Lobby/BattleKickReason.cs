using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Reason why player was kicked from battle
/// </summary>
public class BattleKickReason : AbstractPacket
{
    public static int Id { get; } = -322235316;
    public override string Description => "Reason why player was kicked from battle";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "reason"
    };
}