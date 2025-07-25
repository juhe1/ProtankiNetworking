using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.Status;

/// <summary>
///     Sets the battle status of the player to the battle ID
/// </summary>
public class InBattleStatus : AbstractPacket
{
    public const int ID_CONST = -1895446889;
    public override int Id => ID_CONST;
    public override string Description => "Sets the battle status of the player to the battle ID";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        BattleNotifierCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "battleNotifier"
    };
}