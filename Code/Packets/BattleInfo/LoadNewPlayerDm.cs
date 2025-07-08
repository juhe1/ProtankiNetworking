using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     A new player has joined the battle
/// </summary>
public class LoadNewPlayerDm : AbstractPacket
{
    public static int Id { get; } = 862913394;
    public override string Description => "A new player has joined the battle";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        new VectorCodec(BattleUserCodec.Instance, false)
    };

    public override string[] Attributes => new[]
    {
        "username",
        "userinfos"
    };
}