using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     A new player has joined the team battle
/// </summary>
public class LoadNewPlayerTeam : AbstractPacket
{
    public static int IdStatic { get; } = 2040021062;
    public override int Id => IdStatic;
    public override string Description => "A new player has joined the team battle";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        new VectorCodec(BattleUserCodec.Instance, false),
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "username",
        "userinfos",
        "team"
    };
}