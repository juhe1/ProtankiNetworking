using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Reason why player was kicked from battle
/// </summary>
public class BattleKickReason : AbstractPacket
{
    public const int ID_CONST = -322235316;
    public override int Id => ID_CONST;
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