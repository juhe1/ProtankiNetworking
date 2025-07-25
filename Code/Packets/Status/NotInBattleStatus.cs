using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Status;

/// <summary>
///     Sets the player's battle status to not in battle
/// </summary>
public class NotInBattleStatus : AbstractPacket
{
    public const int ID_CONST = 1941694508;
    public override int Id => ID_CONST;
    public override string Description => "Sets the player's battle status to not in battle";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "username"
    };
}